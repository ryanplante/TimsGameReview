using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IGenreData
    {
        public Task<List<GenreModel>> GetGenres();

    }
}
