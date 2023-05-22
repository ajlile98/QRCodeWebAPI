using Microsoft.AspNetCore.Mvc;
using QRCodeWebAPI.Data;
using QRCodeWebAPI.Models;

namespace QRCodeWebAPI.Controllers{
    public class QRCodeController : ControllerBase{
       IQRCodeRepository _qrCodeRepository; 
       IConfiguration _config;
         public QRCodeController(IConfiguration config, IQRCodeRepository qrCodeRepository){
              _config = config;
              _qrCodeRepository = qrCodeRepository;
         }

        [HttpGet("QRCodes/{qrcodeId}/{userId}/{searchParam}")]
        public IEnumerable<QRCode> GetQRCodes(int qrcodeId=0, int userId=0, string searchParam="None"){
            return _qrCodeRepository.GetQRCodes(qrcodeId, userId, searchParam);
        }

        [HttpGet("GetQRCode/{id}")]
        public QRCode GetQRCode(int id){
            return _qrCodeRepository.GetQRCode(id);
        }

        [HttpPut("UpsertQRCode")]
        public bool UpdateQRCode(QRCode qrCode){
            return _qrCodeRepository.UpsertQRCode(qrCode);
        }

        [HttpDelete("DeleteQRCode/{id}")]
        public bool DeleteQRCode(int id){
            return _qrCodeRepository.DeleteQRCode(id);
        }
    }
}