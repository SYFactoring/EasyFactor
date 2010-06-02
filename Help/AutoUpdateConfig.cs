/*
 * AutoUpdateConfig.cs
 * This class is the definition of the remote XML configuration file
 * 
 * Copyright 2004 Conversive, Inc.
 * 
 */

/*
 * Conversive's C# AutoUpdater Component
 * Copyright 2004 Conversive, Inc.
 * 
 * This is a component which allows automatic software updates.
 * It is written in C# and was developed by Conversive, Inc. on April 14th 2004.
 * 
 * The C# AutoUpdater Component is licensed under the LGPL:
 * ------------------------------------------------------------------------
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 *  * 
 * ------------------------------------------------------------------------
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Xml;

namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// Summary description for AutoUpdateConfig.
    /// </summary>
    public class AutoUpdateConfig
    {
        #region Delegates

        public delegate void LoadConfigErrorEventHandler(string stMessage, Exception loadConfigError);

        #endregion

        public Uri AppFileURL { get; set; }

        public string AvailableVersion { get; set; }

        public Uri ChangeLogURL { get; set; }

        public string LatestChanges { get; set; }


        //?Delegates?(1)?

        //?Events?(1)?
        public event LoadConfigErrorEventHandler OnLoadConfigError;


        //?Public?Methods?(1)?
        /// <summary>
        /// LoadConfig: Invoke this method when you are ready to populate this object
        /// </summary>
        public bool LoadConfig(Uri url, string user, string pass, Uri proxyURL, bool proxyEnabled)
        {
            try
            {
                //Load the xml config file
                var xmlDoc = new XmlDocument();
                //Retrieve the File

                var request = (HttpWebRequest)WebRequest.Create(url);
                //Request.Headers.Add("Translate: f"); //Commented out 11/16/2004 Matt Palmerlee, this Header is more for DAV and causes a known security issue
                request.Credentials = !String.IsNullOrEmpty(user) ? new NetworkCredential(user, pass) : CredentialCache.DefaultCredentials;

                //Added 11/16/2004 For Proxy Clients, Thanks George for submitting these changes
                if (proxyEnabled)
                    request.Proxy = new WebProxy(proxyURL, true);

                var response = (HttpWebResponse)request.GetResponse();

                Stream respStream = response.GetResponseStream();

                //Load the XML from the stream
                xmlDoc.Load(respStream);

                //Parse out the AvailableVersion
                XmlNode availableVersionNode = xmlDoc.SelectSingleNode(@"//AvailableVersion");
                AvailableVersion = availableVersionNode.InnerText;

                //Parse out the AppFileURL
                XmlNode appFileURLNode = xmlDoc.SelectSingleNode(@"//AppFileURL");
                AppFileURL = new Uri(appFileURLNode.InnerText);

                //Parse out the LatestChanges
                XmlNode latestChangesNode = xmlDoc.SelectSingleNode(@"//LatestChanges");
                LatestChanges = latestChangesNode != null ? latestChangesNode.InnerText : "";

                //Parse out the ChangLogURL
                XmlNode changeLogURLNode = xmlDoc.SelectSingleNode(@"//ChangeLogURL");
                ChangeLogURL = changeLogURLNode != null ? new Uri(changeLogURLNode.InnerText) : new Uri("");
            }
            catch (Exception e)
            {
                string stMessage = "Failed to read the config file at: " + url +
                                   "\r\nMake sure that the config file is present and has a valid format.";
                Debug.WriteLine(stMessage);
                //MessageBox.Show(stMessage); 
                if (OnLoadConfigError != null)
                    OnLoadConfigError(stMessage, e);

                return false;
            }
            return true;
        }


        //LoadConfig(string url, string user, string pass)
    }

    //class AutoUpdateConfig
}

//namespace Conversive.AutoUpdater