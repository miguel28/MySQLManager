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
        public override void GenerateCode()
        {
            cols = dbCon.GetAllColumns(setting.TableName);
            colstype = dbCon.GetColsType(setting.TableName);
            colscomment = dbCon.GetColsComment(setting.TableName);
            colsnulable = dbCon.GetColsNullable(setting.TableName);

            GenerateListView();
            GenerateModals();
            GenerateJavaScript();
            _genetaredCode = s.ToString();
        }

        private void GenerateListView()
        {
            string elementlow = setting.TableName.Replace("tbl_", "");
            string element = elementlow[0].ToString().ToUpper() + elementlow.Substring(1);
            string model_name = setting.TableName.Replace("tbl", "mdl");
            string single = elementlow;

            if (single.EndsWith("s"))
                single = single.Substring(0, single.Length - 1);
            string plural = elementlow;
            if (!plural.EndsWith("s"))
                plural = plural + 's';

            string Single = single[0].ToString().ToUpper() + single.Substring(1);

            s.AppendLine("<!-- List View " + single + " -->");
            s.AppendLine("<div class=\"btn-group\">");
            s.AppendLine("  <a class=\"btn btn-success\" data-toggle=\"modal\" ng-click=\"AddNew_" + Single + "()\">Add New " + Single + "</a>");
            s.AppendLine("</div>");
            s.AppendLine();
            s.AppendLine("<div class=\"input-group\" style=\"padding-left: 2rem; width: 95 %\">");
            s.AppendLine("  <span class=\"input-group-addon\">Filter</span>");
            s.AppendLine("  <input id=\"filter\" type=\"text\" class=\"form-control\" placeholder=\"Type here a filter...\" />");
            s.AppendLine("  <div class=\"input-group-btn\">");
            s.AppendLine("      <button class=\"btn btn-danger\" onclick=\"tableClearFilter('#filter')\" >");
            s.AppendLine("          <i class=\"fa fa-remove\"></i>");
            s.AppendLine("      </button>");
            s.AppendLine("  </div>");
            s.AppendLine("</div>");
            s.AppendLine();


            s.AppendLine("<table class=\"table table-striped table-bordered bootstrap-datatable datatable dataTable\">");
            s.AppendLine("	<thead>");
            s.AppendLine("		<tr role=\"row\">");
            foreach(string col in cols)
                s.AppendLine("			<th>" + col + "</th>");
            s.AppendLine("			<th>Actions</th>");
            s.AppendLine("		</tr>");
            s.AppendLine("	</thead>");

            s.AppendLine("	<tbody class=\"searchable\">");
            s.AppendLine("		<tr ng-repeat=\"" + single + " in " + plural + "\" ng-class=\" parseInt(" + single + "." + cols[0] + ") % 2 === 0 ? 'odd' : 'even' \">");
            foreach (string col in cols)
                s.AppendLine("			<td>{{" + single + "." + col + "}}</td>");

            s.AppendLine("				<td class=\"center \">");
            s.AppendLine("				<a class=\"btn btn-success\" data-toggle=\"tooltip\" title=\"View\" href=\"javascript:void(0)\" ng-click=\"View_" + Single + "(" + single + ")\">");
            s.AppendLine("					<i class=\"fa fa-search-plus \"></i>");
            s.AppendLine("				</a>");
            s.AppendLine("				<a class=\"btn btn-info\" data-toggle=\"tooltip\" title=\"Edit\" href=\"javascript:void(0)\" ng-click=\"Edit_" + Single + "(" + single +")\">");
            s.AppendLine("					<i class=\"fa fa-edit \"></i>");
            s.AppendLine("				</a>");
            s.AppendLine("				<a class=\"btn btn-danger\" data-toggle=\"tooltip\" title=\"Delete\" href=\"javascript:void(0)\"> ng-click=\"Delete_" + Single + "(" + single + ")\"");
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
            string elementlow = setting.TableName.Replace("tbl_", "");
            string element = elementlow[0].ToString().ToUpper() + elementlow.Substring(1);
            string model_name = setting.TableName.Replace("tbl", "mdl");
            string single = elementlow;

            if (single.EndsWith("s"))
                single = single.Substring(0, single.Length - 1);
            string plural = elementlow;
            if (!plural.EndsWith("s"))
                plural = plural + 's';

            string Plural = plural[0].ToString() + plural.Substring(1, plural.Length - 1);
            string Single = single[0].ToString().ToUpper() + single.Substring(1);

            s.AppendLine("<!-- Modal edit " + single + " -->");
            s.AppendLine("<div class=\"modal fade\" id=\"modal_edit_" + single + "\" tabindex=\"-1\" role=\"dialog\">");
            s.AppendLine("	<div class=\"modal-dialog\" role=\"document\">");
            s.AppendLine("		<div class=\"modal-content\">");
            s.AppendLine("			<div class=\"modal-header\">");
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
                        s.AppendLine("			  <label for=\"txt_" + cols[i] + "\">" + cols[i] + ":</label>");
                        s.AppendLine("			  <input type=\"password\" class=\"form-control\" id=\"txt_" + cols[i] + "\" maxlength=\"40\" ng-model=\"edit_" + single + "." + cols[i] + "\">");
                        s.AppendLine("			</div>");
                    }
                    else
                    {
                        string len = ctype.Replace("varchar(", "").Replace(")", "");
                        s.AppendLine("			<div class=\"form-group\">");
                        s.AppendLine("			  <label for=\"txt_" + cols[i] + "\">" + cols[i] + ":</label>");
                        s.AppendLine("			  <input type=\"text\" class=\"form-control\" id=\"txt_" + cols[i] + "\" maxlength=\"" + len + "\" ng-model=\"edit_" + single + "." + cols[i] + "\">");
                        s.AppendLine("			</div>");
                    }
                }
                else if (ctype.Contains("date"))
                {
                    s.AppendLine("			<div class=\"form-group\">");
                    s.AppendLine("				<label for=\"txt_" + cols[i] + "\"> " + cols[i] + ":</label>");
                    s.AppendLine("				<div class=\"input-group date form_date\" data-date=\"\" data-date-format=\"dd MM yyyy\" data-link-field=\"dtp1_" + cols[i] + "\" data-link-format=\"yyyy-mm-dd\">");
                    s.AppendLine("					<input id=\"kick\" class=\"form-control\" size=\"16\" type=\"text\" value=\"\" readonly ng-model=\"edit_" + single + "." + cols[i] + "\">");
                    s.AppendLine("					<span class=\"input-group-addon\"><span class=\"glyphicon glyphicon-calendar\"></span></span>");
                    s.AppendLine("				</div>");
                    s.AppendLine("				<input type=\"hidden\"  for=\"txt_" + cols[i] + "\" value=\"\" />");
                    s.AppendLine("			</div>");
                }
                else
                {
                    s.AppendLine("			<div class=\"form-group\">");
                    s.AppendLine("			  <label for=\"txt_" + cols[i] + "\">" + cols[i] + ":</label>");
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
                s.AppendLine("				<p><b>" + col + ": </b>{{view_" + single + "." + col + "}}</p>");
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
            string elementlow = setting.TableName.Replace("tbl_", "");
            string element = elementlow[0].ToString().ToUpper() + elementlow.Substring(1);
            string model_name = setting.TableName.Replace("tbl", "mdl");
            string single = elementlow;

            if (single.EndsWith("s"))
                single = single.Substring(0, single.Length - 1);
            string plural = elementlow;
            if (!plural.EndsWith("s"))
                plural = plural + 's';

            string Plural = plural[0].ToString().ToUpper() + plural.Substring(1);
            string Single = single[0].ToString().ToUpper() + single.Substring(1);

            s.AppendLine("<script>");
            s.AppendLine("function SetupTableFilters()");
            s.AppendLine("{");
            s.AppendLine("  tableFilterEngine('#filter', 'searchable', 'tr');");
            s.AppendLine("}\n");

            s.AppendLine("$(document).ready(function() {");
            s.AppendLine("  SetupTableFilters();");
            s.AppendLine("  var scope = angular.element($(\"#myAppEl\")).scope();");
            s.AppendLine("  scope.LoadAll" + Plural + "s();");
            s.AppendLine("});");

            s.AppendLine("app.controller('DefaultController', function($scope, $http, $sce, $compile)");
            s.AppendLine("{");
            s.AppendLine("  $scope." + plural + " = [];");
            s.AppendLine();

            s.AppendLine("  $scope.LoadAll" + Plural + " = function()");
            s.AppendLine("  {");
            s.AppendLine("      var url = '<?php echo site_url('ctl_" + plural + "')?>/getAll" + Plural + "/';");
            s.AppendLine("      var call = AjaxJSON(url,true);");
            s.AppendLine("      call.UseLock = false;");
            s.AppendLine("      call.Call(");
            s.AppendLine("      	function(result) {");
            s.AppendLine("              if(result.success)");
            s.AppendLine("              {");
            s.AppendLine("                  $scope." + plural + " = result.data;");
            s.AppendLine("                  $scope.$apply();");
            s.AppendLine("              }");
            s.AppendLine("              else");
            s.AppendLine("              {");
            s.AppendLine("                  $scope.ShowPopup(\"Could not load the information: \" + result.message);");
            s.AppendLine("              }");
            s.AppendLine("          }");
            s.AppendLine("      );");
            s.AppendLine("  };");
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
                    if(!echecked)
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

            s.AppendLine("  $scope.SaveChanges_" + Single + " = function()");
            s.AppendLine("  {");
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

            s.AppendLine("  $scope.ConfirmDelete_" + Single + " = function()\"");
            s.AppendLine("  {");
            s.AppendLine("		var url =  '<?php echo site_url('ctl_" + plural + "')?>/delete" + Single + "/';");
            s.AppendLine("		var call = AjaxJSON(url,true);");
            s.AppendLine("		var data =");
            s.AppendLine("		{");
            s.AppendLine("			service_info: JSON.stringify($scope.delete_" + single + ")");
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

            s.AppendLine("  $scope.View_" + Single + " = function(" + single + ")");
            s.AppendLine("	{");
            s.AppendLine("		$scope.view_" + single + " = " + single + ";");
            s.AppendLine("		$('#modal_view_" + single + "').modal('show');");
            s.AppendLine("	};");

            s.AppendLine("  $scope.Edit_" + Single + " = function(" + single + ")");
            s.AppendLine("	{");
            s.AppendLine("		$scope.edit_" + single + " = " + single + ";");
            s.AppendLine("		$scope._edit_title_" + single + " = 'Edit " + single +"';" );
            s.AppendLine("		$('#modal_edit_" + single + "').modal('show');");
            s.AppendLine("	};");

            s.AppendLine("  $scope.Delete_" + Single + " = function(" + single + ")");
            s.AppendLine("	{");
            s.AppendLine("		$scope.delete_" + single + " = " + single + ";");
            s.AppendLine("		$('#modal_delete_" + single + "').modal('show');");
            s.AppendLine("	};");

            JSONEmptyGen g = new JSONEmptyGen();
            g.SetData(dbCon, setting);
            g.GenerateCode();
            s.AppendLine(g.GeneratedCode);

            s.AppendLine("  $scope.AddNew_" + Single + " = function()");
            s.AppendLine("  {");
            s.AppendLine("      $scope.edit_" + single + " = $scope._" + single + "_empty;");
            s.AppendLine("      $scope._edit_title_" + single + " = 'Create new " + single + "';");
            s.AppendLine("      $('#modal_edit_" + single + "').modal('show');");
            s.AppendLine("  };");

            s.AppendLine("});");
            s.AppendLine("</script>");
        }
    }
}
