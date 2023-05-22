namespace QRCodeWebAPI.Models{
    public class QRCode{
        public int QRCodeId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = "";
        public string Data { get; set; } = "";
        public DateTime CreatedDate { get; set; }
    }
}