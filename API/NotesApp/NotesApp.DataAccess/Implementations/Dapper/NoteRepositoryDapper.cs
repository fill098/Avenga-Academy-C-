using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NotesApp.DataAccess.Interfaces;
using NotesApp.Domain.Models;

namespace NotesApp.DataAccess.Implementations.Dapper
{
    public class NoteRepositoryDapper : INoteRepository
    {
        private readonly string _connnectionString;

        public NoteRepositoryDapper(IConfiguration configuration)
        {
            _connnectionString = configuration.GetConnectionString("NotesAppDb") ?? throw
            new InvalidOperationException("Connectionstring in 'NotesAppDb' not found!!");
        }

        private SqlConnection CreateConnection() => new SqlConnection(_connnectionString);
        public async Task<List<Note>> GetAllAsync()
        {
            using SqlConnection connection = CreateConnection();

            string query = "SELECT * FROM dbo.Notes";

            IEnumerable<Note> notes = await connection.QueryAsync<Note>(query);

            return notes.ToList();
        }
        public async Task<Note?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Note>> GetByIdsAsync(List<int> ids)
        {
            throw new NotImplementedException();
        }
        public async Task AddAsync(Note entity)
        {
            throw new NotImplementedException();
        }
        public async Task UpdateAsync(Note entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Note entity)
        {
            throw new NotImplementedException();
        }
    }
}
