﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataLibrary.Db;
using DataLibrary.Models;

namespace DataLibrary.Data
{
    public class GameRatingData : IGameRatingData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public GameRatingData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<int> RateGame(VideoGameModel game, RatingModel rate)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("GameID", game.Id);
            p.Add("Rating", rate.Rating);
            p.Add("Review", rate.Review);

            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("sp_AddReview", p, _connectionString.SqlConnectionName);

            return p.Get<int>("Id");
        }

        public Task<int> DeleteRating(int ratingId)
        {
            return _dataAccess.SaveData("spRatings_Delete", new { Id = ratingId }, _connectionString.SqlConnectionName);
        }

        public async Task<RatingModel> GetRatingById(int ratingId)
        {
            var recs = await _dataAccess.LoadData<RatingModel, dynamic>("spRatings_GetById", new { Id = ratingId }, _connectionString.SqlConnectionName);

            return recs.FirstOrDefault();
        }
    }
}