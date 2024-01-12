using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        [HiddenInput]
        public int Id { get; set; } // Reservation - data, miasto, adres, pokój, właściciel, cena
    }
}