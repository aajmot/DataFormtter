using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFormatter
{
    public partial class FormatData : Form
    {
        public FormatData()
        {
            InitializeComponent();
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            try
            {
                string _source = txtSource.Text.Trim();
                string _jsonParserMessage = "";
                bool _jsonParseStatus = IsValidJson(_source, out _jsonParserMessage);
                if (_jsonParseStatus)
                {
                    var jsonObject = JToken.Parse(_source);
                    DisplayTreeView(jsonObject, "Root");
                }
                else
                {
                    MessageBox.Show(_jsonParserMessage, "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void DisplayTreeView(JToken root, string rootName)
        {
            try
            {
                tvTarget.BeginUpdate();
                try
                {
                    tvTarget.Nodes.Clear();
                    var tNode = tvTarget.Nodes[tvTarget.Nodes.Add(new TreeNode(rootName))];
                    tNode.Tag = root;

                    AddNode(root, tNode);

                    tvTarget.CollapseAll();
                }
                finally
                {
                    tvTarget.EndUpdate();
                }
            }
            catch
            {
                throw;
            }
        }

        private void AddNode(JToken token, TreeNode inTreeNode)
        {
            try
            {
                if (token == null)
                    return;
                if (token is JValue)
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(token.ToString()))];
                    childNode.Tag = token;
                }
                else if (token is JObject)
                {
                    var obj = (JObject)token;
                    foreach (var property in obj.Properties())
                    {
                        var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(property.Name))];
                        childNode.Tag = property;
                        AddNode(property.Value, childNode);
                    }
                }
                else if (token is JArray)
                {
                    var array = (JArray)token;
                    for (int i = 0; i < array.Count; i++)
                    {
                        var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(i.ToString()))];
                        childNode.Tag = array[i];
                        AddNode(array[i], childNode);
                    }
                }
                else
                {
                    Debug.WriteLine(string.Format("{0} not implemented", token.Type)); // JConstructor, JRaw
                }
            }
            catch
            {

                throw;
            }
        }


        private static bool IsValidJson(string strInput, out string message)
        {
            try
            {
                message = string.Empty;
                strInput = strInput.Trim();
                if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                    (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
                {
                    try
                    {
                        var obj = JToken.Parse(strInput);
                        return true;
                    }
                    catch (JsonReaderException jex)
                    {
                        message = "Json not valid!Failed to parase json data." + jex.Message;
                        return false;
                    }
                    catch (Exception ex)
                    {
                        message = "Json not valid!Exception occured while parsing." + ex.Message;
                        return false;
                    }
                }
                else
                {
                    message = "Json not valid!Please check start and ending braces.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                message = "Something bad happned!Please contact admin so he can look into this matter.";
                return false;
            }
        }
    }
}
