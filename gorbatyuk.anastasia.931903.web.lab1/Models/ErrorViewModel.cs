using System;

namespace gorbatyuk.anastasia._931903.web.lab1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class Actions
    {
        public int val1 { get; set; }
        public int val2 { get; set; }
        public int div { get; set; }
        public int sub { get; set; }
        public int add { get; set; }
        public int mul { get; set; }
    }
}
