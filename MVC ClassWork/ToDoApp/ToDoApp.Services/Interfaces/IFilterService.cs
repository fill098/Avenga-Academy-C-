using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Models.Dtos;

namespace ToDoApp.Services.Interfaces
{
    public interface IFilterService
    {
        List<StatusDto> GetStatuses();

        List<CategoryDto> GetCategories();
    }
}
