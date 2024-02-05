// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the login flow of users using App Service Authentication/Authorization. </summary>
    public partial class WebAppLoginInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WebAppLoginInfo"/>. </summary>
        public WebAppLoginInfo()
        {
            AllowedExternalRedirectUrls = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="WebAppLoginInfo"/>. </summary>
        /// <param name="routes"> The routes that specify the endpoints used for login and logout requests. </param>
        /// <param name="tokenStore"> The configuration settings of the token store. </param>
        /// <param name="preserveUrlFragmentsForLogins"> &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request is made; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="allowedExternalRedirectUrls">
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </param>
        /// <param name="cookieExpiration"> The configuration settings of the session cookie's expiration. </param>
        /// <param name="nonce"> The configuration settings of the nonce used in the login flow. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAppLoginInfo(LoginRoutes routes, AppServiceTokenStore tokenStore, bool? preserveUrlFragmentsForLogins, IList<string> allowedExternalRedirectUrls, WebAppCookieExpiration cookieExpiration, LoginFlowNonceSettings nonce, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Routes = routes;
            TokenStore = tokenStore;
            PreserveUrlFragmentsForLogins = preserveUrlFragmentsForLogins;
            AllowedExternalRedirectUrls = allowedExternalRedirectUrls;
            CookieExpiration = cookieExpiration;
            Nonce = nonce;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The routes that specify the endpoints used for login and logout requests. </summary>
        internal LoginRoutes Routes { get; set; }
        /// <summary> The endpoint at which a logout request should be made. </summary>
        public string RoutesLogoutEndpoint
        {
            get => Routes is null ? default : Routes.LogoutEndpoint;
            set
            {
                if (Routes is null)
                    Routes = new LoginRoutes();
                Routes.LogoutEndpoint = value;
            }
        }

        /// <summary> The configuration settings of the token store. </summary>
        public AppServiceTokenStore TokenStore { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request is made; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? PreserveUrlFragmentsForLogins { get; set; }
        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </summary>
        public IList<string> AllowedExternalRedirectUrls { get; }
        /// <summary> The configuration settings of the session cookie's expiration. </summary>
        public WebAppCookieExpiration CookieExpiration { get; set; }
        /// <summary> The configuration settings of the nonce used in the login flow. </summary>
        public LoginFlowNonceSettings Nonce { get; set; }
    }
}
