using Tuxber.Common.Models;
using Tuxber.Web.Data.Entities;

namespace Tuxber.Web.Helpers
{
    public interface IConverterHelper
    {
        TaxiResponse ToTaxiResponse(TaxiEntity taxiEntity);
    }
}
