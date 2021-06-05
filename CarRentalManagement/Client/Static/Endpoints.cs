using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public class Endpoints
    {
        public static string Prefix = "api";

        public static string MakesEndpoint = $"{Prefix}/makes";
        public static string VehiclesEndpoint = $"{Prefix}/vehicles";
        public static string ModelsEndpoint = $"{Prefix}/models";
        public static string BookingsEndpoint = $"{Prefix}/bookings";
        public static string CustomersEndpoint = $"{Prefix}/customers";
        public static string ColoursEndpoint = $"{Prefix}/colours";
        
        //ErrorMaker endpoints
        public static string ErrorBadRequest = $"{Prefix}/ErrorMaker/bad-request";
        public static string ErrorNotFound = $"{Prefix}/ErrorMaker/not-found";
        public static string ErrorUnauthorized= $"{Prefix}/ErrorMaker/UnAuthorized";
        public static string ErrorInternalServerError = $"{Prefix}/ErrorMaker/internal-server-error";
    }
}
