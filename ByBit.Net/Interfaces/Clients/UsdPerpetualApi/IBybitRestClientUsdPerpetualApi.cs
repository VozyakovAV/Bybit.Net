﻿using CryptoExchange.Net.Interfaces;
using System;

namespace Bybit.Net.Interfaces.Clients.UsdPerpetualApi
{
    /// <summary>
    /// Bybit USD perpetual API endpoints
    /// </summary>
    public interface IBybitRestClientUsdPerpetualApi : IRestApiClient, IDisposable
    {
        /// <summary>
        /// Endpoints related to account settings, info or actions
        /// </summary>
        IBybitRestClientUsdPerpetualApiAccount Account { get; }

        /// <summary>
        /// Endpoints related to retrieving market and system data
        /// </summary>
        IBybitRestClientUsdPerpetualApiExchangeData ExchangeData { get; }

        /// <summary>
        /// Endpoints related to orders and trades
        /// </summary>
        IBybitRestClientUsdPerpetualApiTrading Trading { get; }
    }
}