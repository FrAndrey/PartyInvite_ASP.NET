using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvc.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }

        }
        public static void AddGuestResponse (GuestResponse guestResponse)
        {
            responses.Add(guestResponse);
        }

    }
}
