using INFITF;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CatiaApi
{
    public class CatiaUtils
    {
        public static INFITF.Application Connect(bool startIfNotRunning)
        {
            INFITF.Application catiaApp = null;
            try
            {
                // Attempt to get an existing instance of CATIA.Application
                catiaApp = (INFITF.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");
                catiaApp.Visible = true;
                return catiaApp;
            }
            catch (Exception)
            {
                if (startIfNotRunning)
                {
                    // CATIA is not running, so start it
                    try
                    {
                        catiaApp = (INFITF.Application)Activator.CreateInstance(Type.GetTypeFromProgID("CATIA.Application"));
                        catiaApp.Visible = true;
                        return catiaApp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to start CATIA: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
                else
                    return null;
            }
        }

        public static Document ConnectToDocument(INFITF.Application catiaApp)
        {
            try
            {
                return catiaApp.ActiveDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to active document: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static Document ConnectToDocument(INFITF.Application catiaApp, string filePath)
        {
            return catiaApp.Documents.Open(filePath); // if the file is opened, it will be only activated
        }

        public static Document CreateDocument(INFITF.Application catiaApp, string docType)
        {
            string[] docTypes = new string[] { "Part", "Product", "Drawing" };
            if (docTypes.Contains(docType))
            {
                try
                {
                    return (Document)catiaApp.Documents.Add(docType);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create document: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
                return null;
        }

        public static bool OpenDocument(INFITF.Application catiaApp, string filePath)
        {
            if (FileUtils.FileDirectoryExists(filePath))
            {
                try
                {
                    catiaApp.Documents.Open(filePath);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public static bool SaveDocument(INFITF.Application catiaApp)
        {
            try
            {
                Document doc = catiaApp.ActiveDocument;
                doc.Save();
                MessageBox.Show("File was successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the active document: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool SaveDocument(INFITF.Application catiaApp, string filePath)
        {          
            if (FileUtils.FileDirectoryExists(filePath))
            {
                try
                {
                    Document doc = catiaApp.ActiveDocument;
                    doc.SaveAs(filePath);
                    MessageBox.Show("File was successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                try
                {
                    Document doc = catiaApp.ActiveDocument;
                    filePath = FileUtils.SelectSavingPath(GetActiveDocumentExtension(catiaApp));
                    if (filePath != string.Empty)
                    {
                        doc.SaveAs(filePath);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to save the file. Please select a valid path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        public static void CloseDocument(INFITF.Application catiaApp)
        {
            Document doc = ConnectToDocument(catiaApp);
            doc.Close();
        }

        public static void CloseDocument(INFITF.Application catiaApp, string filePath)
        {
            Document doc = ConnectToDocument(catiaApp, filePath);
            doc.Close();
        }

        public static void CloseAllDocuments(INFITF.Application catiaApp)
        {
            Documents docs = catiaApp.Documents;
            foreach (Document doc in docs)
            {
                doc.Close();
            }
        }

        public static string GetActiveDocumentType(INFITF.Application catiaApp)
        {
            try
            {
                // Create a new instance of CATIA.Application
                catiaApp = (INFITF.Application)Activator.CreateInstance(Type.GetTypeFromProgID("CATIA.Application"));

                // Check if CATIA.Application was successfully created
                if (catiaApp != null)
                {
                    // Start CATIA
                    catiaApp.Visible = true;

                    // Access the active document
                    Document activeDoc = catiaApp.ActiveDocument;

                    // Check if an active document exists
                    if (activeDoc != null)
                    {
                        string docName = activeDoc.get_Name();
                        if (docName.EndsWith(".CATPart"))
                            return "PartDocument";
                        else if (docName.EndsWith(".CATProduct"))
                            return "ProductDocument";
                        else if (docName.EndsWith(".CATDrawing"))
                            return "DrawingDocument";
                        else if (docName.EndsWith(".CATScript"))
                            return "ScriptDocument";
                        else if (docName.EndsWith(".CATAnalysis"))
                            return "AnalysisDocument"; // simulation 
                        else if (docName.EndsWith(".CATMaterial"))
                            return "MaterialDocument";
                        else if (docName.EndsWith(".CATProcess"))
                            return "ProcessDocument"; // manufacturing processes
                        else if (docName.EndsWith(".CATShape"))
                            return "ShapeDocument";
                        else
                            return "Unknown";
                    }
                    else
                        return "Error";
                }
                else
                    return "Error";
            }
            catch (Exception)
            {
                return "Error";
            }
        }

        public static string GetActiveDocumentExtension(INFITF.Application catiaApp)
        {
            try
            {
                // Create a new instance of CATIA.Application
                catiaApp = (INFITF.Application)Activator.CreateInstance(Type.GetTypeFromProgID("CATIA.Application"));

                // Check if CATIA.Application was successfully created
                if (catiaApp != null)
                {
                    // Start CATIA
                    catiaApp.Visible = true;

                    // Access the active document
                    Document activeDoc = catiaApp.ActiveDocument;

                    // Check if an active document exists
                    if (activeDoc != null)
                    {
                        string docName = activeDoc.get_Name();
                        string[] parts = docName.Split('.');
                        if (parts.Length > 0)
                        {
                            return parts[parts.Length - 1];
                        }
                        return string.Empty;
                    }
                    else
                        return string.Empty;
                }
                else
                    return string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static bool CloseCatiaApp(INFITF.Application catiaApp) 
        {
            try
            {
                // Release the CATIA.Application object if it was created
                if (catiaApp != null)
                {
                    catiaApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(catiaApp);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
