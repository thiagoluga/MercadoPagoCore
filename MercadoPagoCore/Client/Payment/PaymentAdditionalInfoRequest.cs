using System.Collections.Generic;

namespace MercadoPagoCore.Client.Payment
{
    /// <summary>
    /// Data that could improve fraud analysis and conversion rates.
    /// Try to send as much information as possible.
    /// </summary>
    public class PaymentAdditionalInfoRequest
    {
        /// <summary>
        /// IP from where the request comes from (only for bank transfers).
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// List of items to be paid.
        /// </summary>
        public List<PaymentItemRequest> Items { get; set; }

        /// <summary>
        /// Payer's information.
        /// </summary>
        public PaymentAdditionalInfoPayerRequest Payer { get; set; }

        /// <summary>
        /// Shipping information.
        /// </summary>
        public PaymentShipmentsRequest Shipments { get; set; }
    }
}
