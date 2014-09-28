<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Merger.aspx.cs" Inherits="Merger" %>
<%@ Register Assembly="AjaxControlToolkit"  Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PDF MERGER TOOL</title>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="CSS/merge.css" type="text/css" media="screen"/>
    <script type="text/javascript">

       
</script>
    <script>

    </script>

 
</head>

<body>
    <form id="form1" runat="server" >
        <div class="container">
            <div class="row vertical-center-row">
                <div class="col-lg-12">
                    <div class="row ">
                        <div class="col-md-8 col-md-offset-2 col-sm-6 col-sm-offset-2 col-xs-6 col-xs-offset-2">
                            <div>

                                <asp:Panel ID="Panel1" runat="server">
                                    <table class="tab">
                                        <tr>
                                            <td style="text-align: center">
                                                <label>
                                                    <h1>PDF MERGER</h1>
                                                </label>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td>
                                                <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" />
                                                <ajaxToolkit:AjaxFileUpload ID="AjaxFileUpload1" OnClientUploadComplete="" runat="server" ThrobberID="myThrobber"  MaximumNumberOfFiles="10" AllowedFileTypes="" OnUploadComplete="AjaxFileUpload1_UploadComplete1" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button Text="Start" ID="btnStart" CssClass="btn-block btn-primary btn-lg" runat="server" OnClick="btnStart_Click" /></td>
                                        </tr>
                                    </table>


                                </asp:Panel>

                            </div>
                </div>
            </div>
                </div>
            </div>
        </div>


    </form>
</body>
</html>
