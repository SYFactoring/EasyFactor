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
using System.Xml;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// Summary description for AutoUpdateConfig.
    /// </summary>
    public class AutoUpdateConfig
    {
		#region?Fields?(4)?

        private Uri _AppFileURL;
        private string _AvailableVersion;
        private Uri _ChangeLogURL;
        private string _LatestChanges;

		#endregion?Fields?

		#region?Properties?(4)?

        public Uri AppFileURL
        { get { return _AppFileURL; } set { _AppFileURL = value; } }

        public string AvailableVersion
        { get { return _AvailableVersion; } set { _AvailableVersion = value; } }

        public Uri ChangeLogURL
        { get { return _ChangeLogURL; } set { _ChangeLogURL = value; } }

        public string LatestChanges
        { get { return _LatestChanges; } set { _LatestChanges = value; } }

		#endregion?Properties?

		#region?Delegates?and?Events?(2)?

		//?Delegates?(1)?

        public delegate void LoadConfigError(string stMessage, Exception e);
		//?Events?(1)?

        public event LoadConfigError OnLoadConfigError;

		#endregion?Delegates?and?Events?

		#region?Methods?(1)?

		//?Public?Methods?(1)?

        /// <summary>
        /// LoadConfig: Invoke this method when you are ready to populate this object
        /// </summary>
        public bool LoadConfig(Uri url, string user, string pass, Uri proxyURL, bool proxyEnabled)
        {
            try
            {
                //Load the xml config file
                XmlDocument XmlDoc = new XmlDocument();
                HttpWebResponse Response;
                HttpWebRequest Request;
                //Retrieve the File

                Request = (HttpWebRequest)HttpWebRequest.Create(url);
                //Request.Headers.Add("Translate: f"); //Commented out 11/16/2004 Matt Palmerlee, this Header is more for DAV and causes a known security issue
                if (!String.IsNullOrEmpty(user))
                    Request.Credentials = new NetworkCredential(user, pass);
                else
                    Request.Credentials = CredentialCache.DefaultCredentials;

                //Added 11/16/2004 For Proxy Clients, Thanks George for submitting these changes
                if (proxyEnabled == true)
                    Request.Proxy = new WebProxy(proxyURL, true);

                Response = (HttpWebResponse)Request.GetResponse();

                Stream respStream = null;
                respStream = Response.GetResponseStream();

                //Load the XML from the stream
                XmlDoc.Load(respStream);

                //Parse out the AvailableVersion
                XmlNode AvailableVersionNode = XmlDoc.SelectSingleNode(@"//AvailableVersion");
                this.AvailableVersion = AvailableVersionNode.InnerText;

                //Parse out the AppFileURL
                XmlNode AppFileURLNode = XmlDoc.SelectSingleNode(@"//AppFileURL");
                this.AppFileURL = new Uri(AppFileURLNode.InnerText);

                //Parse out the LatestChanges
                XmlNode LatestChangesNode = XmlDoc.SelectSingleNode(@"//LatestChanges");
                if (LatestChangesNode != null)
                    this.LatestChanges = LatestChangesNode.InnerText;
                else
                    this.LatestChanges = "";

                //Parse out the ChangLogURL
                XmlNode ChangeLogURLNode = XmlDoc.SelectSingleNode(@"//ChangeLogURL");
                if (ChangeLogURLNode != null)
                    this.ChangeLogURL = new Uri(ChangeLogURLNode.InnerText);
                else
                    this.ChangeLogURL = new Uri("");

            }
            catch (Exception e)
            {
                string stMessage = "Failed to read the config file at: " + url + "\r\nMake sure that the config file is present and has a valid format.";
                Debug.WriteLine(stMessage);
                //MessageBox.Show(stMessage); 
                if (this.OnLoadConfigError != null)
                    this.OnLoadConfigError(stMessage, e);

                return false;
            }
            return true;
        }

		#endregion?Methods?

//LoadConfig(string url, string user, string pass)
    }//class AutoUpdateConfig
}//namespace Conversive.AutoUpdater
