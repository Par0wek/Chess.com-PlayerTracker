using ChessApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChessApi.Services
{
    public interface IRestService
    {
        Task<ApiResponse> GetUserProfileAsync(string query);
        Task<ApiResponse> GetStatsAsync(string query);
    }
}
