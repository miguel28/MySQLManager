using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager
{
    public class HTML_Generator : ICodeGenerator
    {
        public override void GenerateCode()
        {
            cols = dbCon.GetAllColumns(setting.TableName);
            GenerateBasicFunctions();
        }

        private void GenerateBasicFunctions()
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
            s.AppendLine("				<a class=\"btn btn-success\" data-toggle=\"tooltip\" title=\"View\" href=\"javascript:void(0)\" ng-click=\"View(project)\">");
            s.AppendLine("					<i class=\"fa fa-search-plus \"></i>");
            s.AppendLine("				</a>");
            s.AppendLine("				<a class=\"btn btn-info\" data-toggle=\"tooltip\" title=\"Information\" href=\"javascript:void(0)\" ng-click=\"OpenProjectInfo(project)\">");
            s.AppendLine("					<i class=\"fa fa-edit \"></i>");
            s.AppendLine("				</a>");
            s.AppendLine("				<a class=\"btn btn-default\" data-toggle=\"tooltip\" title=\"Configuration\" ng-if=\"IsAdmin()\" href=\"javascript:void(0)\">");
            s.AppendLine("					<i class=\"fa fa-wrench\"></i>");
            s.AppendLine("				</a>");
            s.AppendLine("				<a class=\"btn btn-danger\" data-toggle=\"tooltip\" title=\"Delete\" ng-if=\"IsAdmin()\" href=\"javascript:void(0)\">");
            s.AppendLine("					<i class=\"fa fa-trash-o \"></i>");
            s.AppendLine("				</a>");
            s.AppendLine("			</td>");
            s.AppendLine("		</tr>");
            s.AppendLine("	</tbody>");
            s.AppendLine("</table>");


            _genetaredCode = s.ToString();
        }
    }
}
