using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NotesApp.DataAccess.Interfaces;
using NotesApp.Domain.Enums;
using NotesApp.Domain.Models;
using System.Data;

namespace NotesApp.DataAccess.Implementations.AddNet
{
    public class NoteRepositoryAdoNet : INoteRepository
    {
        private readonly string _connnectionString;
        public NoteRepositoryAdoNet(IConfiguration configuration)
        {
            _connnectionString = configuration.GetConnectionString("NotesAppDb") ?? throw
            new InvalidOperationException("Connectionstring in 'NotesAppDb' not found!!"); 
        }

        private const string SelectNotesSql = @"
        SELECT  n.Id          AS NoteId,
                n.Text        AS NoteText,
                n.Priority    AS NotePriority,
                n.UserId      AS NoteUserId,
                n.CreatedDate AS NoteCreatedDate,
                n.UpdatedDate AS NoteUpdatedDate,
                u.Id          AS UserId,
                u.FirstName   AS UserFirstName,
                u.LastName    AS UserLastName,
                u.Username    AS UserUsername,
                t.Id          AS TagId,
                t.Name        AS TagName,
                t.Color       AS TagColor
        FROM       dbo.Note    n
        LEFT JOIN  dbo.[User]  u  ON u.Id = n.UserId
        LEFT JOIN  dbo.NoteTag nt ON nt.NoteId = n.Id
        LEFT JOIN  dbo.Tag     t  ON t.Id = nt.TagId";
        public async Task<List<Note>> GetAllAsync()
        {
            using SqlConnection connection = new SqlConnection(connectionString: _connnectionString);
            await connection.OpenAsync();

            string sqlQuery = SelectNotesSql + " ORDER BY n.Id";

            using SqlCommand command = new SqlCommand(sqlQuery, connection);

            using SqlDataReader reader = await command.ExecuteReaderAsync();

            var notes = await ReadNotesAsync(reader);

            return notes;


        }
        public async Task<Note?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task AddAsync(Note entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Note entity)
        {
            throw new NotImplementedException();
        }



        public async Task<List<Note>> GetByIdsAsync(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Note entity)
        {
            throw new NotImplementedException();
        }

        #region Helper methods
        private static async Task<List<Note>> ReadNotesAsync(SqlDataReader reader)
        {
            Dictionary<int, Note> notesById = new Dictionary<int, Note>();

            while (await reader.ReadAsync())
            {
                int noteId = (int)reader["NoteId"];

                if (!notesById.TryGetValue(noteId, out Note? note))
                {
                    note = new Note
                    {
                        Id = noteId,
                        Text = (string)reader["NoteText"],

                        Priority = Enum.Parse<Priority>((string)reader["NotePriority"]),

                        UserId = reader["NoteUserId"] as int?,

                        CreatedDate = (DateTime)reader["NoteCreatedDate"],
                        UpdatedDate = (DateTime)reader["NoteUpdatedDate"]
                    };

                    if (reader["UserId"] is int userId)
                    {
                        note.User = new User
                        {
                            Id = userId,
                            FirstName = (string)reader["UserFirstName"],
                            LastName = (string)reader["UserLastName"],
                            Username = (string)reader["UserUsername"]
                        };
                    }

                    notesById.Add(noteId, note);
                }

                if (reader["TagId"] is int tagId)
                {
                    note.Tags.Add(new Tag
                    {
                        Id = tagId,
                        Name = (string)reader["TagName"],
                        Color = (string)reader["TagColor"]
                    });
                }
            }

            return notesById.Values.ToList();
        }

        private static void AddNoteParameters(SqlCommand command, Note entity)
        {
            command.Parameters.AddWithValue("@Text", entity.Text);

            command.Parameters.AddWithValue("@Priority", entity.Priority.ToString());

            command.Parameters.AddWithValue("@UserId", (object?)entity.UserId ?? DBNull.Value);

            command.Parameters.Add("@CreatedDate", SqlDbType.DateTime2).Value = entity.CreatedDate;
            command.Parameters.Add("@UpdatedDate", SqlDbType.DateTime2).Value = entity.UpdatedDate;
        }

        private static async Task InsertTagsAsync(
           SqlConnection connection, SqlTransaction transaction, Note entity)
        {
            const string insertTagSql =
                "INSERT INTO dbo.NoteTag (NoteId, TagId) VALUES (@NoteId, @TagId);";

            // One round trip per tag. Fine for five, wrong for five thousand.
            foreach (Tag tag in entity.Tags)
            {
                using SqlCommand command = new SqlCommand(insertTagSql, connection, transaction);
                command.Parameters.AddWithValue("@NoteId", entity.Id);
                command.Parameters.AddWithValue("@TagId", tag.Id);

                await command.ExecuteNonQueryAsync();
            }
        }
        #endregion
    }
}
