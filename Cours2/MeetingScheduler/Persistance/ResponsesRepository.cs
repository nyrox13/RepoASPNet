using MeetingScheduler.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingScheduler.Persistance
{
    public static class ResponsesRepository
    {
        private static List<GuestResponse> responses = new();

        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}
