using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using valentines.Models;
using Microsoft.AspNetCore.Http;

namespace valentines.Repositories
{
    public class CandiesRepository
    {
        private readonly IDbConnection _db;
        public CandiesRepository(IDbConnection db)
        {
            _db = db;
        }
        public IEnumerable<Candy> Get()
        {
            return _db.Query<Candy>("SELECT * FROM candies");
        }
    }
}