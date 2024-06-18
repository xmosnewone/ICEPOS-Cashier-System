namespace ICE.Utility
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    public class XMLUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static XMLUtility _instance;
        
        
        
        private XMLUtility()
        {

        }
        
        
        
        public static XMLUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new XMLUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region
        
        
        
        
        
        
        public Dictionary<String, String> GetNodesText(String xmlPath, String[] nodeName)
        {
            Dictionary<String, String> result = null;
            XmlDocument xmlDocument = null;
            XmlNamespaceManager nsmgr = null;
            try
            {
                if (File.Exists(xmlPath))
                {
                    if (nodeName.Length > 0)
                    {
                        result = new Dictionary<String, String>();
                    }
                    xmlDocument = new XmlDocument();
                    xmlDocument.Load(Path.GetFileName(xmlPath));
                    nsmgr = new XmlNamespaceManager(xmlDocument.NameTable);
                    for (int index = 0; index < nodeName.Length; index++)
                    {
                        XmlNode xmlNode = xmlDocument.SelectSingleNode(nodeName[index], nsmgr);
                        if (!result.ContainsKey(nodeName[index]))
                        {
                            result.Add(nodeName[index], xmlNode.InnerText);
                        }
                    }
                }
            }
            catch (IOException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {

            }
            return result;
        }
        
        
        
        
        
        
        
        public bool SetNodesText(String xmlPath, String nodeName, String nodeText)
        {
            bool isok = false;
            XmlDocument xmlDocument = null;
            XmlNamespaceManager nsmgr = null;
            try
            {
                if (File.Exists(xmlPath))
                {
                    xmlDocument = new XmlDocument();
                    xmlDocument.Load(Path.GetFileName(xmlPath));
                    nsmgr = new XmlNamespaceManager(xmlDocument.NameTable);
                    XmlNode xmlNode = xmlDocument.SelectSingleNode(nodeName, nsmgr);
                    xmlNode.InnerText = nodeText;
                    XmlElement Xe = (XmlElement)xmlNode;
                    Xe.SetAttribute("value", nodeText);
                    isok = true;
                    xmlDocument.Save(xmlPath);
                }
            }
            catch (IOException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {

            }
            return isok;
        }
        
        
        
        
        
        
        public bool WriteXmlFile(String xmlPath, Dictionary<String, Object> dicParameters, String rootElement)
        {
            bool isok = false;
            XmlTextWriter xmlTextWriter = null;
            try
            {
                if (File.Exists(xmlPath))
                {
                    File.Delete(xmlPath);
                }
                xmlTextWriter = new XmlTextWriter(xmlPath, System.Text.Encoding.UTF8);
                xmlTextWriter.Formatting = Formatting.Indented;
                xmlTextWriter.Indentation = 4;
                xmlTextWriter.WriteStartDocument();
                xmlTextWriter.WriteStartElement(rootElement);
                foreach (KeyValuePair<String, Object> kv in dicParameters)
                {
                    xmlTextWriter.WriteStartElement(kv.Key);
                    xmlTextWriter.WriteValue(kv.Value);
                    xmlTextWriter.WriteEndElement();
                }
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndDocument();
                isok = true;
            }
            catch (IOException)
            {
                isok = false;
            }
            catch (XmlException)
            {
                isok = false;
            }
            catch (Exception)
            {
                isok = false;
            }
            finally
            {
                if (xmlTextWriter != null)
                {
                    xmlTextWriter.Flush();
                    xmlTextWriter.Close();
                }
            }
            return isok;
        }
        #endregion
    }
}
