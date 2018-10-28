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
        public override void GenerateCode()
        {
            cols = dbCon.GetAllColumns(setting.TableName);
            colstype = dbCon.GetColsType(setting.TableName);
            colscomment = dbCon.GetColsComment(setting.TableName);

            GenerateListView();
            GenerateModals();

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

            s.AppendLine("<div class=\"btn-group\">");
            s.AppendLine("  <a class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#dia_new_" + elementlow + "\">Add New " + element + "</a>");
            s.AppendLine("</div>");
            s.AppendLine();
            s.AppendLine("<div class=\"input-group\" style=\"padding-left: 2rem; width: 95 %\">");
            s.AppendLine("  <span class=\"input-group-addon\">Filter</span>");
            s.AppendLine("      <input id=\"filter\" type=\"text\" class=\"form-control\" placeholder=\"Type here a filter...\" />");
            s.AppendLine("      <span class=\"input-group-addon\">Filter</span>");
            s.AppendLine("  </div>");
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
            s.AppendLine("		<tr ng-repeat=\"" + single + " in " + plural + "s\" ng-class=\" parseInt(" + single + "." + cols[0] + ") % 2 === 0 ? 'odd' : 'even' \">");
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

            string Single = single[0].ToString().ToUpper() + single.Substring(1);

            s.AppendLine("<!-- Modal -->");
            s.AppendLine("<div class=\"modal fade\" id=\"modal_view_" + single + "\" tabindex=\"-1\" role=\"dialog\">");
            s.AppendLine("	<div class=\"modal-dialog\" role=\"document\">");
            s.AppendLine("		<div class=\"modal-content\">");
            s.AppendLine("			<div class=\"modal-header\">");
            s.AppendLine("				<h3 class=\"modal-title\">{{_view_title_" + single + "}}</h3>");
            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-body\">");
            foreach (string col in cols)
                s.AppendLine("				<p><b>" + col + ": </b>{{view_" + single + "." + col + "}}</p>");

            for(int i = 0; i < cols.Count; i++)
            {
                string ctype = colstype[i];
                if (ctype.Contains("varchar"))
                {
                    if(colscomment[i].Contains("password"))
                    {
                        s.AppendLine("			<div class=\"form-group\">");
                        s.AppendLine("			  <label for=\"txt_" + cols[i] + "\">" + cols[i] + ":</label>");
                        s.AppendLine("			  <input type=\"password\" class=\"form-control\" id=\"txt_" + cols[i] + "\" maxlength=\"40\">");
                        s.AppendLine("			</div>");
                    }
                    else
                    {
                        string len = ctype.Replace("varchar", "").Replace(")", "");
                        s.AppendLine("			<div class=\"form-group\">");
                        s.AppendLine("			  <label for=\"txt_" + cols[i] + "\">" + cols[i] + ":</label>");
                        s.AppendLine("			  <input type=\"text\" class=\"form-control\" id=\"txt_" + cols[i] + "\" maxlength=\"" + len + "\">");
                        s.AppendLine("			</div>");
                    }
                }
                else if (ctype.Contains("date"))
                {
                    s.AppendLine("			<div class=\"form-group\">");
                    s.AppendLine("				<label for=\"kick\">Delivery Date:</label>");
                    s.AppendLine("				<div class=\"input-group date form_date\" data-date=\"\" data-date-format=\"dd MM yyyy\" data-link-field=\"dtp_input2\" data-link-format=\"yyyy-mm-dd\">");
                    s.AppendLine("					<input id=\"kick\" class=\"form-control\" size=\"16\" type=\"text\" value=\"\" readonly ng-model=\"editing_project.project_kickoff_date\">");
                    s.AppendLine("					<span class=\"input-group-addon\"><span class=\"glyphicon glyphicon-calendar\"></span></span>");
                    s.AppendLine("				</div>");
                    s.AppendLine("				<input type=\"hidden\" id=\"dtp_input2\" value=\"\" />");
                    s.AppendLine("			</div>");
                }
                else
                {
                    s.AppendLine("			<div class=\"form-group\">");
                    s.AppendLine("			  <label for=\"txt_" + cols[i] + "\">" + cols[i] + ":</label>");
                    s.AppendLine("			  <input type=\"text\" class=\"form-control\" id=\"txt_" + cols[i] + "\">");
                    s.AppendLine("			</div>");
                }
            }


            s.AppendLine("			</div>");
            s.AppendLine("			<div class=\"modal-footer\">");
            s.AppendLine("				<button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>");
            s.AppendLine("			</div>");
            s.AppendLine("		</div>");
            s.AppendLine("	</div>");
            s.AppendLine("</div>");
            s.AppendLine("<!-- Modal -->");


            s.AppendLine("<!-- Modal -->");
            s.AppendLine("<div class=\"modal fade\" id=\"modal_edit_" + single + "\" tabindex=\"-1\" role=\"dialog\">");
            s.AppendLine("	<div class=\"modal-dialog\" role=\"document\">");
            s.AppendLine("		<div class=\"modal-content\">");
            s.AppendLine("			<div class=\"modal-header\">");
            s.AppendLine("				<h3 class=\"modal-title\">Edit " + single + "</h3>");
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
            s.AppendLine("<!-- Modal -->");


        }


    }
}
