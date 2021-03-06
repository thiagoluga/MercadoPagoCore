using MercadoPagoCore.Client.Common;

namespace MercadoPagoCore.Client.Payment
{
    /// <summary>
    /// Receiver address.
    /// </summary>
    public class PaymentReceiverAddressRequest : AddressRequest
    {
        /// <summary>
        /// State.
        /// </summary>
        public string StateName { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// Floor.
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// Apartment.
        /// </summary>
        public string Apartment { get; set; }
    }
}
