﻿using System;
using Newtonsoft.Json;

namespace SiftScienceNet.Events
{
    [JsonConverter(typeof(PaymentTypeConverter))]
    public enum PaymentType
    {
        CreditCard, 
        ElectronicFundTransfer, 
        StoreCredit, 
        GiftCard, 
        Points, 
        Financing,  
        ThirdPartyProcessor,
        Cash,
        Check,
        CryptoCurrency,
        Interac,
        Invoice,
        MoneyOrder,
        Masterpass,
        Voucher
    }

    public class PaymentTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            PaymentType paymentType = (PaymentType)value;

            if (paymentType == PaymentType.CreditCard)
                writer.WriteValue("$credit_card");

            if (paymentType == PaymentType.ElectronicFundTransfer)
                writer.WriteValue("$electronic_fund_transfer");

            if (paymentType == PaymentType.Financing)
                writer.WriteValue("$financing");

            if (paymentType == PaymentType.StoreCredit)
                writer.WriteValue("$store_credit");

            if (paymentType == PaymentType.GiftCard)
                writer.WriteValue("$gift_card");

            if (paymentType == PaymentType.Points)
                writer.WriteValue("$points");

            if (paymentType == PaymentType.ThirdPartyProcessor)
                writer.WriteValue("$third_party_processor");

            if (paymentType == PaymentType.Cash)
                writer.WriteValue("$cash");

            if (paymentType == PaymentType.Check)
                writer.WriteValue("$check");

            if (paymentType == PaymentType.CryptoCurrency)
                writer.WriteValue("$crypto_currency");

            if (paymentType == PaymentType.Interac)
                writer.WriteValue("$interac");

            if (paymentType == PaymentType.Invoice)
                writer.WriteValue("$invoice");

            if (paymentType == PaymentType.MoneyOrder)
                writer.WriteValue("$money_order");

            if (paymentType == PaymentType.Masterpass)
                writer.WriteValue("$masterpass");

            if (paymentType == PaymentType.Voucher)
                writer.WriteValue("$voucher");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(PaymentType);
        }
    }
}