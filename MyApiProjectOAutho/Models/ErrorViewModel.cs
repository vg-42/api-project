namespace MyApiProjectOAutho.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string? RequestIdOne { get; set; }
        public string? RequestIdTwo { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
