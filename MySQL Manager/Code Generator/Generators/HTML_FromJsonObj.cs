using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MySQL_Manager
{
    public class HTML_FromJsonObj : ICodeGenerator
    {
        private string json;
        private string _element = "";
        private JObject obj = null;
        private List<string> colstype = new List<string>();
        private List<string> colscomment = new List<string>();
        private List<string> colsnulable = new List<string>();

        private string elementlow;
        private string element;
        private string single;
        private string Plural;
        private string plural;
        private string Single;

        private string common;
        public void SetJson(string jsontxt, string el)
        {
            json = jsontxt;
            _element = el;
        }

        public override void GenerateCode()
        {
            
            try
            {
                if (string.IsNullOrEmpty(json))
                    return;
                obj = JObject.Parse(json);
            }
            catch
            {
                return;
            }

            cols = new List<string>();
            foreach (JProperty prop in (JToken)obj)
            {
                if (prop.Type != JTokenType.Array)
                {
                    cols.Add(prop.Name);
                    string t = "text";
                    if (prop.Type == JTokenType.String 
                        || prop.Type == JTokenType.Float 
                        || prop.Type == JTokenType.Integer
                        )
                        t = ("text");
                    
                    if (prop.Name.Contains("date"))
                        t =("date");

                    if (prop.Type == JTokenType.Array)
                    {
                        t = "array";
                    }

                    colstype.Add(t);

                    colscomment.Add("");
                    colsnulable.Add("");
                }
                    
            }

            common = cols[0].Replace("id", "");

            elementlow = _element.ToLower();
            element = elementlow[0].ToString().ToUpper() + elementlow.Substring(1);
            single = elementlow;

            if (single.EndsWith("s"))
                single = single.Substring(0, single.Length - 1);
            plural = elementlow;
            if (!plural.EndsWith("s"))
                plural = plural + 's';

            Plural = plural[0].ToString() + plural.Substring(1, plural.Length - 1);
            Single = single[0].ToString().ToUpper() + single.Substring(1);

            GenerateModals();
            GenerateJavaScript();
            _genetaredCode = s.ToString();
        }

        private void GenerateModals()
        {
            s.AppendLine("<!-- Modal edit " + single + " -->");
            s.AppendLine("<div class=\"modal fade\" id=\"modal_edit_" + single + "\" tabindex=\"-1\" role=\"dialog\">");
            s.AppendLine("	<div class=\"modal-dialog\" role=\"document\">");
            s.AppendLine("		<div class=\"modal-content\">");
            s.AppendLine("			<div class=\"modal-header\">");
            s.AppendLine("				<h3 class=\"modal-title\">{{_edit_title_" + single + "}}</h3>");
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-body\">");

            for (int i = 1; i < cols.Count; i++)
            {
                string ctype = colstype[i];
                if (ctype.Contains("varchar"))
                {
                    if (colscomment[i].Contains("password"))
                    {
                        s.AppendLine("			<div class=\"form-group\">");
                        s.AppendLine("			  <label for=\"txt_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                        s.AppendLine("			  <input type=\"password\" class=\"form-control\" id=\"txt_" + cols[i] + "\" maxlength=\"40\" ng-model=\"edit_" + single + "." + cols[i] + "\">");
                        s.AppendLine("			</div>");
                    }
                    else
                    {
                        string len = ctype.Replace("varchar(", "").Replace(")", "");
                        s.AppendLine("			<div class=\"form-group\">");
                        s.AppendLine("			  <label for=\"txt_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                        s.AppendLine("			  <input type=\"text\" class=\"form-control\" id=\"txt_" + cols[i] + "\" maxlength=\"" + len + "\" ng-model=\"edit_" + single + "." + cols[i] + "\">");
                        s.AppendLine("			</div>");
                    }
                }
                else if (ctype.Contains("date"))
                {
                    s.AppendLine("			<div class=\"form-group\">");
                    s.AppendLine("				<label for=\"txt_" + cols[i] + "\"> " + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("				<div class=\"input-group date form_date\" data-date=\"\" data-date-format=\"dd MM yyyy\" data-link-field=\"dtp1_" + cols[i] + "\" data-link-format=\"yyyy-mm-dd\">");
                    s.AppendLine("					<input id=\"kick\" class=\"form-control\" size=\"16\" type=\"text\" value=\"\" readonly ng-model=\"edit_" + single + "." + cols[i] + "\">");
                    s.AppendLine("					<span class=\"input-group-addon\"><span class=\"glyphicon glyphicon-calendar\"></span></span>");
                    s.AppendLine("				</div>");
                    s.AppendLine("				<input type=\"hidden\"\tfor=\"txt_" + cols[i] + "\" value=\"\" />");
                    s.AppendLine("			</div>");
                }
                else
                {
                    s.AppendLine("			<div class=\"form-group\">");
                    s.AppendLine("			  <label for=\"txt_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("			  <input type=\"text\" class=\"form-control\" id=\"txt_" + cols[i] + "\" ng-model=\"edit_" + single + "." + cols[i] + "\">");
                    s.AppendLine("			</div>");
                }
            }
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-footer\">");
            s.AppendLine("				<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
            s.AppendLine("				<button type=\"button\" class=\"btn btn-success\" ng-click=\"SaveChanges_" + Single + "()\" >Save</button>");
            s.AppendLine("			</div>");
            s.AppendLine("		</div>");
            s.AppendLine("	</div>");
            s.AppendLine("</div>");
            s.AppendLine("<!-- Modal edit " + single + " -->");


            s.AppendLine("<!-- Modal view " + single + " -->");
            s.AppendLine("<div class=\"modal fade\" id=\"modal_view_" + single + "\" tabindex=\"-1\" role=\"dialog\">");
            s.AppendLine("	<div class=\"modal-dialog\" role=\"document\">");
            s.AppendLine("		<div class=\"modal-content\">");
            s.AppendLine("			<div class=\"modal-header\">");
            s.AppendLine("				<h3 class=\"modal-title\">View " + single + "</h3>");
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-body\">");
            foreach (string col in cols)
                s.AppendLine("				<p><b>" + SanitizeColumnName(col, common) + ": </b>{{view_" + single + "." + col + "}}</p>");
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-footer\">");
            s.AppendLine("				<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>");
            s.AppendLine("			</div>");
            s.AppendLine("		</div>");
            s.AppendLine("	</div>");
            s.AppendLine("</div>");
            s.AppendLine("<!-- Modal view " + single + " -->");

            s.AppendLine("<!-- Modal delete " + single + " -->");
            s.AppendLine("<div class=\"modal fade\" id=\"modal_delete_" + single + "\" tabindex=\"-1\" role=\"dialog\">");
            s.AppendLine("	<div class=\"modal-dialog\" role=\"document\">");
            s.AppendLine("		<div class=\"modal-content\">");
            s.AppendLine("			<div class=\"modal-header\">");
            s.AppendLine("				<h3 class=\"modal-title\">Are you sure to delete this register " + single + "</h3>");
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-body\">");
            foreach (string col in cols)
                s.AppendLine("				<p><b>" + col + ": </b>{{delete_" + single + "." + col + "}}</p>");
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-footer\">");
            s.AppendLine("				<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>");
            s.AppendLine("				<button type=\"button\" class=\"btn btn-danger\" ng-click=\"ConfirmDelete_" + Single + "()\">Delete</button>");
            s.AppendLine("			</div>");
            s.AppendLine("		</div>");
            s.AppendLine("	</div>");
            s.AppendLine("</div>");
            s.AppendLine("<!-- Modal view " + single + " -->");

            s.AppendLine();
        }

        public void GenerateJavaScript()
        {
            s.AppendLine("<script>");
            s.AppendLine("function SetupTableFilters()");
            s.AppendLine("{");
            s.AppendLine("\ttableFilterEngine('#filter', 'searchable', 'tr');");
            s.AppendLine("}\n");

            s.AppendLine("$(document).ready(function() {");
            s.AppendLine("\tSetupTableFilters();");
            s.AppendLine("\tvar scope = angular.element($(\"#myAppEl\")).scope();");
            s.AppendLine("\tscope.LoadAll" + Plural + "s();");
            s.AppendLine("});");

            s.AppendLine("app.controller('DefaultController', function($scope, $http, $sce, $compile)");
            s.AppendLine("{");
            s.AppendLine("\t$scope." + plural + " = [];");
            s.AppendLine();

            s.AppendLine("\t$scope.LoadAll" + Plural + " = function()");
            s.AppendLine("\t{");
            s.AppendLine("\t\tvar url = '<?php echo site_url('ctl_" + plural + "')?>/getAll" + Plural + "/';");
            s.AppendLine("\t\tvar call = AjaxJSON(url,true);");
            s.AppendLine("\t\tcall.UseLock = false;");
            s.AppendLine("\t\tcall.Call(");
            s.AppendLine("\t\t	function(result) {");
            s.AppendLine("\t\t\t\tif(result.success)");
            s.AppendLine("\t\t\t\t{");
            s.AppendLine("\t\t\t\t\t$scope." + plural + " = result.data;");
            s.AppendLine("\t\t\t\t\t$scope.$apply();");
            s.AppendLine("\t\t\t\t}");
            s.AppendLine("\t\t\t\telse");
            s.AppendLine("\t\t\t\t{");
            s.AppendLine("\t\t\t\t\t$scope.ShowPopup(\"Could not load the information: \" + result.message);");
            s.AppendLine("\t\t\t\t}");
            s.AppendLine("\t\t\t}");
            s.AppendLine("\t\t);");
            s.AppendLine("\t};");
            s.AppendLine();

            s.AppendLine("	$scope.edit_" + single + " = {};");
            s.AppendLine("	$scope.Load" + Single + " = function(id)");
            s.AppendLine("	{");
            s.AppendLine("		if ((typeof id == 'undefined') || (id === '0') || (id === ''))");
            s.AppendLine("			return;");
            s.AppendLine();
            s.AppendLine("		var url =  '<?php echo site_url('ctl_" + plural + "')?>/get" + Single + "Info/' + id;");
            s.AppendLine("		var call = AjaxJSON(url,true);");
            s.AppendLine("		call.UseLock = false;");
            s.AppendLine("		call.Call(");
            s.AppendLine("			function(result) {");
            s.AppendLine("				if(result.success)");
            s.AppendLine("				{");
            s.AppendLine("					$scope.edit_" + single + " = result.data;");
            s.AppendLine("					$scope.$apply();");
            s.AppendLine("				}");
            s.AppendLine("				else");
            s.AppendLine("				{");
            s.AppendLine("					$scope.ShowPopup(\"Could not load information: \" + result.message);");
            s.AppendLine("				}");
            s.AppendLine("			}");
            s.AppendLine("		);");
            s.AppendLine("	};");

            s.AppendLine("	$scope.InfoCheck_" + Single + " = function()");
            s.AppendLine("	{");
            bool echecked = false;
            s.Append("		return");
            for (int i = 1; i < cols.Count; i++)
            {
                if (colsnulable[i].Contains("NO"))
                {
                    if (!echecked)
                        s.AppendLine(" $scope.edit_" + single + "." + cols[i] + " !== \"\"");
                    else
                        s.AppendLine("				&& $scope.edit_" + single + "." + cols[i] + " !== \"\"");
                    echecked = true;
                }
            }

            if (!echecked)
                s.AppendLine(" true");
            s.AppendLine(";");
            s.AppendLine("	};");
            s.AppendLine();

            s.AppendLine("\t$scope.SaveChanges_" + Single + " = function()");
            s.AppendLine("\t{");
            s.AppendLine("		if (!$scope.InfoCheck_" + Single + "())");
            s.AppendLine("		{");
            s.AppendLine("			$scope.ShowPopup(\"There are fields needed to fill!\");");
            s.AppendLine("			return;");
            s.AppendLine("		}");
            s.AppendLine("		");
            s.AppendLine("		var url =  '<?php echo site_url('ctl_" + plural + "')?>/update" + Single + "Info/';");
            s.AppendLine("		var call = AjaxJSON(url,true);");
            s.AppendLine("		var data =");
            s.AppendLine("		{");
            s.AppendLine("			service_info: JSON.stringify($scope.edit_" + single + ")");
            s.AppendLine("		};");
            s.AppendLine("		call.Data = data;");
            s.AppendLine("		call.UseLock = true;");
            s.AppendLine("		call.Call(");
            s.AppendLine("			function(result) {");
            s.AppendLine("				if(result.success)");
            s.AppendLine("				{");
            s.AppendLine("					$scope.LoadAll" + Plural + "();");
            s.AppendLine("					$('#modal_edit_" + single + "\').modal(\'hide\');");
            s.AppendLine("				}");
            s.AppendLine("				else");
            s.AppendLine("				{");
            s.AppendLine("					$scope.ShowPopup(\"Could not load information: \" + result.message);");
            s.AppendLine("				}");
            s.AppendLine("			}");
            s.AppendLine("		);");
            s.AppendLine("	};");

            s.AppendLine("\t$scope.ConfirmDelete_" + Single + " = function()\"");
            s.AppendLine("\t{");
            s.AppendLine("		var url =  '<?php echo site_url('ctl_" + plural + "')?>/delete" + Single + "/';");
            s.AppendLine("		var call = AjaxJSON(url,true);");
            s.AppendLine("		var data =");
            s.AppendLine("		{");
            s.AppendLine("			" + single + ": JSON.stringify($scope.delete_" + single + ")");
            s.AppendLine("		};");
            s.AppendLine("		call.Data = data;");
            s.AppendLine("		call.UseLock = true;");
            s.AppendLine("		call.Call(");
            s.AppendLine("			function(result) {");
            s.AppendLine("				if(result.success)");
            s.AppendLine("				{");
            s.AppendLine("					$scope.LoadAll" + Plural + "();");
            s.AppendLine("					$('#modal_delete_" + single + "\').modal(\'hide\');");
            s.AppendLine("				}");
            s.AppendLine("				else");
            s.AppendLine("				{");
            s.AppendLine("					$scope.ShowPopup(\"Could not load information: \" + result.message);");
            s.AppendLine("				}");
            s.AppendLine("			}");
            s.AppendLine("		);");
            s.AppendLine("	};");

            s.AppendLine("\t$scope.View_" + Single + " = function(" + single + ")");
            s.AppendLine("	{");
            s.AppendLine("		$scope.view_" + single + " = " + single + ";");
            s.AppendLine("		$('#modal_view_" + single + "').modal('show');");
            s.AppendLine("	};");

            s.AppendLine("\t$scope.Edit_" + Single + " = function(" + single + ")");
            s.AppendLine("	{");
            s.AppendLine("		$scope.edit_" + single + " = " + single + ";");
            s.AppendLine("		$scope._edit_title_" + single + " = 'Edit " + single + "';");
            s.AppendLine("		$('#modal_edit_" + single + "').modal('show');");
            s.AppendLine("	};");

            s.AppendLine("\t$scope.Delete_" + Single + " = function(" + single + ")");
            s.AppendLine("	{");
            s.AppendLine("		$scope.delete_" + single + " = " + single + ";");
            s.AppendLine("		$('#modal_delete_" + single + "').modal('show');");
            s.AppendLine("	};");


            s.AppendLine(json);

            s.AppendLine("\t$scope.AddNew_" + Single + " = function()");
            s.AppendLine("\t{");
            s.AppendLine("\t\t$scope.edit_" + single + " = $scope._" + single + "_empty;");
            s.AppendLine("\t\t$scope._edit_title_" + single + " = 'Create new " + single + "';");
            s.AppendLine("\t\t$('#modal_edit_" + single + "').modal('show');");
            s.AppendLine("\t};");

            s.AppendLine("});");
            s.AppendLine("</script>");
        }
    }
}
