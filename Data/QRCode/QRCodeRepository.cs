using QRCodeWebAPI.Models;

namespace QRCodeWebAPI.Data {
    public class QRCodeRepository : IQRCodeRepository
    {
        public IEnumerable<QRCode> GetQRCodes(int qrcodeId = 0, int userId = 0, string searchParam = "None")
        {
            throw new NotImplementedException();
        }
        public QRCode GetQRCode(int id)
        {
            throw new NotImplementedException();
        }
        public bool UpsertQRCode(QRCode qrCode)
        {
            throw new NotImplementedException();
        }
        public bool DeleteQRCode(int id)
        {
            throw new NotImplementedException();
        }

    }
}