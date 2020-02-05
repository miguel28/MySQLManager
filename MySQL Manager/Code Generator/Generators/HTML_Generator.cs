using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager
{
    public class HTML_Generator : ICodeGenerator
    {
        private List<string> colstype;
        private List<string> colscomment;
        private List<string> colsnulable;

        private string common;

        private string elementlow;
        private string element;
        private string single;
        private string Plural;
        private string plural;
        private string model_name;
        private string Single;

        public override void GenerateCode()
        {
            cols = dbCon.GetAllColumns(setting.TableName);
            colstype = dbCon.GetColsType(setting.TableName);
            colscomment = dbCon.GetColsComment(setting.TableName);
            colsnulable = dbCon.GetColsNullable(setting.TableName);

            common = cols[0].Replace("id", "");

            elementlow = setting.TableName.Replace("tbl_", "");
            element = elementlow[0].ToString().ToUpper() + elementlow.Substring(1);
            model_name = setting.TableName.Replace("tbl", "mdl");
            single = elementlow;

            if (single.EndsWith("s"))
                single = single.Substring(0, single.Length - 1);
            plural = elementlow;
            if (!plural.EndsWith("s"))
                plural = plural + 's';

            Plural = plural[0].ToString().ToUpper() + plural.Substring(1);
            Single = single[0].ToString().ToUpper() + single.Substring(1);

            GenerateListView();
            GenerateModals();
            GenerateJavaScript();
            _genetaredCode = s.ToString();
        }

        private void GenerateListView()
        {
            s.AppendLine("<!-- List View " + single + " -->");
            s.AppendLine("<div class=\"btn-group\">");
            s.AppendLine("\t<a class=\"btn btn-success\" data-toggle=\"modal\" ng-click=\"AddNew_" + Single + "()\">Add New " + Single + "</a>");
            s.AppendLine("</div>");
            s.AppendLine("<br/><br/>");
            s.AppendLine();
            s.AppendLine("<div class=\"input-group\" style=\"padding-left: 2rem; width: 95%;\">");
            s.AppendLine("\t<span class=\"input-group-addon\">Filter</span>");
            s.AppendLine("\t<input id=\"filter\" type=\"text\" class=\"form-control\" placeholder=\"Type here a filter...\" />");
            s.AppendLine("\t<div class=\"input-group-btn\">");
            s.AppendLine("\t\t<button class=\"btn btn-danger\" onclick=\"tableClearFilter('#filter')\" >");
            s.AppendLine("\t\t\t<i class=\"fa fa-remove\"></i>");
            s.AppendLine("\t\t</button>");
            s.AppendLine("\t</div>");
            s.AppendLine("</div>");
            s.AppendLine();


            s.AppendLine("<table class=\"table table-striped table-bordered bootstrap-datatable datatable dataTable\">");
            s.AppendLine("	<thead>");
            s.AppendLine("		<tr role=\"row\">");
            foreach(string col in cols)
                s.AppendLine("			<th>" + SanitizeColumnName(col, common) + "</th>");
            s.AppendLine("			<th>Actions</th>");
            s.AppendLine("		</tr>");
            s.AppendLine("	</thead>");

            s.AppendLine("	<tbody class=\"searchable\">");
            s.AppendLine("		<tr ng-repeat=\"" + single + " in " + plural + "\" ng-class=\" parseInt(" + single + "." + cols[0] + ") % 2 === 0 ? 'odd' : 'even' \">");
            foreach (string col in cols)
                s.AppendLine("		<td>{{" + single + "." + col + "}}</td>");

            s.AppendLine("				<td class=\"center \">");
            s.AppendLine("				<a class=\"btn btn-success\" data-toggle=\"tooltip\" title=\"View\" href=\"\" ng-click=\"View_" + Single + "(" + single + ")\">");
            s.AppendLine("					<i class=\"fa fa-search-plus \"></i>");
            s.AppendLine("				</a>");
            s.AppendLine("				<a class=\"btn btn-info\" data-toggle=\"tooltip\" title=\"Edit\" href=\"\" ng-click=\"Edit_" + Single + "(" + single +")\">");
            s.AppendLine("					<i class=\"fa fa-edit \"></i>");
            s.AppendLine("				</a>");
            s.AppendLine("				<a class=\"btn btn-danger\" data-toggle=\"tooltip\" title=\"Delete\" href=\"\" ng-click=\"Delete_" + Single + "(" + single + ")\">");
            s.AppendLine("					<i class=\"fa fa-trash-o \"></i>");
            s.AppendLine("				</a>");
            s.AppendLine("			</td>");
            s.AppendLine("		</tr>");
            s.AppendLine("	</tbody>");
            s.AppendLine("</table>");
            s.AppendLine("<!-- List View " + single + " -->");
            s.AppendLine();
        }

        private void GenerateModals()
        {
            s.AppendLine("<!-- Modal edit " + single + " -->");
            s.AppendLine("<div class=\"modal fade\" id=\"modal_edit_" + single + "\" tabindex=\"-1\" role=\"dialog\">");
            s.AppendLine("	<div class=\"modal-dialog\" role=\"document\">");
            s.AppendLine("		<div class=\"modal-content\">");
            s.AppendLine("			<div class=\"modal-header\">");
            s.AppendLine("				<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>");
            s.AppendLine("				<h3 class=\"modal-title\">{{_edit_title_" + single + "}}</h3>");
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-body\">");

            for(int i = 1; i < cols.Count; i++)
            {
                string ctype = colstype[i];
                if (ctype.Contains("varchar"))
                {
                    if(colscomment[i].Contains("password"))
                    {
                        s.AppendLine("			<div class=\"form-group\">");
                        s.AppendLine("				<label for=\"txt_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                        s.AppendLine("				<input type=\"password\" class=\"form-control\" id=\"txt_" + cols[i] + "\" maxlength=\"40\" ng-model=\"edit_" + single + "." + cols[i] + "\">");
                        s.AppendLine("			</div>");
                    }
                    else if (colscomment[i].Contains("COMBO="))
                    {
                        string[] data = colscomment[i].Replace("COMBO=(", "").Replace(");", "").Split(',');
                        s.AppendLine("				<div class=\"form-group\">");
                        s.AppendLine("					<label for=\"sel_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                        s.AppendLine("					<select class=\"form-control\" id=\"sel_" + cols[i] + "\" ng-model=\"edit_" + single + "." + cols[i] + "\">");
                        foreach (string input in data)
                        {
                            string iinput = input.Trim();
                            if (iinput.Contains("="))
                            {
                                string[] valuekey = iinput.Split('=');
                                
                                s.AppendLine("						<option value='" + valuekey[0] + "'>" + valuekey[1] + "</option>");
                            }
                            else
                            {
                                s.AppendLine("						<option value='" + iinput + "'>" + iinput + "</option>");
                            }
                            
                        }
                        s.AppendLine("					</select>");
                        s.AppendLine("				</div>");
                    }
                    else
                    {
                        string len = ctype.Replace("varchar(", "").Replace(")", "");
                        s.AppendLine("				<div class=\"form-group\">");
                        s.AppendLine("					<label for=\"txt_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                        s.AppendLine("					<input type=\"text\" class=\"form-control\" id=\"txt_" + cols[i] + "\" maxlength=\"" + len + "\" ng-model=\"edit_" + single + "." + cols[i] + "\">");
                        s.AppendLine("				</div>");
                    }
                }
                else if (ctype.Contains("int(1)") || ctype.Contains("tinyint"))
                {
                    s.AppendLine("			<div class=\"checkbox\">");
                    s.AppendLine("				<label><input type=\"checkbox\" value=\"\" ng-model=\"edit_" + single + "." + cols[i] + "\" ng-true-value=\"'1'\" ng-false-value=\"'0'\" > " + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("			</div>");
                }
                else if (ctype.Contains("text"))
                {
                    s.AppendLine("				<div class=\"form-group\">");
                    s.AppendLine("					<label for=\"txt_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("					<textarea class=\"form-control\" rows=\"5\" id=\"txt_" + cols[i] + "\" ng-model=\"edit_" + single + "." + cols[i] + "\"></textarea>");
                    s.AppendLine("				</div>");
                }
                else if (ctype.Contains("date"))
                {
                    s.AppendLine("				<div class=\"form-group\">");
                    s.AppendLine("					<label for=\"txt_" + cols[i] + "\"> " + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("					<div class=\"input-group date form_date\" data-date=\"\" data-date-format=\"dd MM yyyy\" data-link-field=\"dtp1_" + cols[i] + "\" data-link-format=\"yyyy-mm-dd\">");
                    s.AppendLine("						<input id=\"kick\" class=\"form-control\" size=\"16\" type=\"text\" value=\"\" readonly ng-model=\"edit_" + single + "." + cols[i] + "\">");
                    s.AppendLine("						<span class=\"input-group-addon\"><span class=\"glyphicon glyphicon-calendar\"></span></span>");
                    s.AppendLine("					</div>");
                    s.AppendLine("					<input type=\"hidden\"\tfor=\"txt_" + SanitizeColumnName(cols[i], common) + "\" value=\"\" />");
                    s.AppendLine("				</div>");
                }
                else
                {
                    s.AppendLine("				<div class=\"form-group\">");
                    s.AppendLine("					<label for=\"txt_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("					<input type=\"text\" class=\"form-control\" id=\"txt_" + cols[i] + "\" ng-model=\"edit_" + single + "." + cols[i] + "\">");
                    s.AppendLine("				</div>");
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
            s.AppendLine("				<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>");
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-body\">");
            for (int i = 1; i < cols.Count; i++)
            {
                if (colstype[i].Contains("text"))
                {
                    s.AppendLine("			<div class=\"form-group\">");
                    s.AppendLine("				<label for=\"txt_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("				<textarea class=\"form-control\" rows=\"5\" readonly id=\"txt_" + cols[i] + "\" ng-value=\"view_" + single + "." + cols[i] + "\"></textarea>");
                    s.AppendLine("			</div>");
                }
                else if (colstype[i].Contains("int(1)") || colstype[i].Contains("tinyint"))
                {
                    s.AppendLine("				<p><b>" + SanitizeColumnName(cols[i], common) + ": </b>{{view_" + single + "." + cols[i] + " === '1' ? 'Yes' : 'No'}}</p>");
                }
                else
                {
                    s.AppendLine("				<p><b>" + SanitizeColumnName(cols[i], common) + ": </b>{{view_" + single + "." + cols[i] + "}}</p>");
                }
            }
               
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
            s.AppendLine("				<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>");
            s.AppendLine("				<h3 class=\"modal-title\">Are you sure to delete this register " + single + "?</h3>");
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-body\">");
            for (int i = 1; i < cols.Count; i++)
            {
                if (colstype[i].Contains("text"))
                {
                    s.AppendLine("			<div class=\"form-group\">");
                    s.AppendLine("				<label for=\"txt_" + cols[i] + "\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("				<textarea class=\"form-control\" rows=\"5\" readonly id=\"txt_" + cols[i] + "\" ng-model=\"delete_" + single + "." + cols[i] + "\"></textarea>");
                    s.AppendLine("			</div>");
                }
                else if (colstype[i].Contains("int(1)") || colstype[i].Contains("tinyint"))
                {
                    s.AppendLine("				<p><b>" + SanitizeColumnName(cols[i], common) + ": </b>{{delete_" + single + "." + cols[i] + " === '1' ? 'Yes' : 'No'}}</p>");
                }
                else
                {
                    s.AppendLine("				<p><b>" + SanitizeColumnName(cols[i], common) + ": </b>{{delete_" + single + "." + cols[i] + "}}</p>");
                }
            }
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-footer\">");
            s.AppendLine("				<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>");
            s.AppendLine("				<button type=\"button\" class=\"btn btn-danger\" ng-click=\"ConfirmDelete_" + Single + "()\">Delete</button>");
            s.AppendLine("			</div>");
            s.AppendLine("		</div>");
            s.AppendLine("	</div>");
            s.AppendLine("</div>");
            s.AppendLine("<!-- Modal delete " + single + " -->");

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
            s.AppendLine("\tscope.LoadAll" + Plural + "();");
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
            s.AppendLine("		if ((typeof id === 'undefined') || (id === '0') || (id === ''))");
            s.AppendLine("			return;");
            s.AppendLine();
            s.AppendLine("		var url =  '<?php echo site_url('ctl_" + plural + "')?>/get" + Single + "Info/';");

            s.AppendLine("		var call = AjaxJSON(url,true);");
            s.AppendLine("		call.UseLock = false;");
            s.AppendLine("		call.Data = {id: id};");

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
            s.AppendLine("		var ret = [];");
            s.AppendLine(@"		var decimal_patt = /\A[+-]?\d+(?:\.\d{1,2})?\z/;");
            for (int i = 1; i < cols.Count; i++)
            {
                if (colsnulable[i].Contains("NO"))
                {
                    s.AppendLine("		if ($scope.edit_" + single + "." + cols[i] + " === \"\") ret.push('" + SanitizeColumnName(cols[i]) + " is empty field');");
                }

                if (colstype[i].Contains("double"))
                {
                    s.AppendLine("		if (decimal_patt.test($scope.edit_" + single + "." + cols[i] + ")) ret.push('" + SanitizeColumnName(cols[i]) + " has invalid format');");
                }
            }
            s.AppendLine("		return ret;");

            s.AppendLine("	};");
            s.AppendLine();

            s.AppendLine("\t$scope.SaveChanges_" + Single + " = function()");
            s.AppendLine("	{");
            s.AppendLine("		var check_info = $scope.InfoCheck_" + Single + "();");
            s.AppendLine("		if (check_info.length > 0)");
            s.AppendLine("		{");
            s.AppendLine("			var msg = 'There are fields needed to fill or have invalid format! <br/>';");
            s.AppendLine("			for(var i= 0; i< check_info.length; i++) msg += check_info[i] + ' <br/>';");
            s.AppendLine("			$scope.ShowPopup(msg);");
            s.AppendLine("			return;");
            s.AppendLine("		}");
            s.AppendLine("		");
            s.AppendLine("		var url =  '<?php echo site_url('ctl_" + plural + "')?>/update" + Single + "Info/';");
            s.AppendLine("		var call = AjaxJSON(url,true);");
            s.AppendLine("		var data =");
            s.AppendLine("		{");
            s.AppendLine("			" + single + "_info: JSON.stringify($scope.edit_" + single + ")");
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

            s.AppendLine("\t$scope.ConfirmDelete_" + Single + " = function()");
            s.AppendLine("\t{");
            s.AppendLine("		var url =  '<?php echo site_url('ctl_" + plural + "')?>/delete" + Single + "Info/';");
            s.AppendLine("		var call = AjaxJSON(url,true);");
            s.AppendLine("		var data =");
            s.AppendLine("		{");
            s.AppendLine("			" + single + "_info: JSON.stringify($scope.delete_" + single + ")");
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
            s.AppendLine("		$scope._edit_title_" + single + " = 'Edit " + single +"';" );
            s.AppendLine("		$('#modal_edit_" + single + "').modal('show');");
            s.AppendLine("	};");

            s.AppendLine("\t$scope.Delete_" + Single + " = function(" + single + ")");
            s.AppendLine("	{");
            s.AppendLine("		$scope.delete_" + single + " = " + single + ";");
            s.AppendLine("		$('#modal_delete_" + single + "').modal('show');");
            s.AppendLine("	};");

            JSONEmptyGen g = new JSONEmptyGen();
            g.SetData(dbCon, setting);
            g.GenerateCode();
            s.AppendLine(g.GeneratedCode);

            s.AppendLine("\t$scope.AddNew_" + Single + " = function()");
            s.AppendLine("\t{");
            s.AppendLine("\t\t$scope.edit_" + single + " = JSON.parse(JSON.stringify($scope._" + single + "_empty));");
            s.AppendLine("\t\t$scope._edit_title_" + single + " = 'Create new " + single + "';");
            s.AppendLine("\t\t$('#modal_edit_" + single + "').modal('show');");
            s.AppendLine("\t};");

            s.AppendLine("});");
            s.AppendLine("</script>");
        }
    }
}
