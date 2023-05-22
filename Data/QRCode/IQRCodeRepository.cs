using QRCodeWebAPI.Models;

namespace QRCodeWebAPI.Data {
    public interface IQRCodeRepository {
        IEnumerable<QRCode> GetQRCodes(int qrcodeId=0, int userId=0, string searchParam="None");
        QRCode GetQRCode(int id);
        bool UpsertQRCode(QRCode qrCode);
        bool DeleteQRCode(int id);
    }
}