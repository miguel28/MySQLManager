using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager
{
    public class CodeGenerator
    {
        private DBConnection dbCon;
        private TableSetting setting;
        private StringBuilder s;
        private List<string> cols;
        private string _genetaredCode = "";

        public CodeGenerator(DBConnection db, TableSetting set)
        {
            dbCon = db;
            setting = set;
        }

        public string GeneratedCode
        {
            get
            {
                return _genetaredCode;
            }
        }
        public void GenerateCode()
        {
            s = new StringBuilder();
            cols = dbCon.GetAllColumns(setting.TableName);
            GenerateBasicFunctions();
        }
        
        private void GenerateBasicFunctions()
        {
            // Begin the Code Igniter class
            s.AppendLine("class " + setting.ClassName + " extends CI_Model {");
		
		    s.AppendLine("");
		    s.AppendLine("	public function __construct()");
		    s.AppendLine("	{");
		    s.AppendLine("		parent::__construct();");
		    s.AppendLine("	}");
		    s.AppendLine("	");
		
		    //Append Insert Function
		    s.Append("	public function insertEntry(");
		
		    for(int i = 1; i< cols.Count-1; i++)
			    s.Append("$" + cols[i] + ", ");
		    s.AppendLine("$" + cols[cols.Count-1] + ")");
		    s.AppendLine("	{");
		    s.AppendLine("		$data = array(");
		
		    for(int i = 1; i< cols.Count-1; i++)
			    s.AppendLine("			'" + cols[i] + "' => $" + cols[i] + ",");
            s.AppendLine("			'" + cols[cols.Count - 1] + "' => $" + cols[cols.Count - 1]);
		
		    s.AppendLine("		);");
		    s.AppendLine("		$this->db->insert('" + setting.TableName + "', $data);");
		    s.AppendLine("		return $this->db->insert_id();");
		    s.AppendLine("	}");
		    s.AppendLine("	");
		
		    //Append Delete Function
		    s.Append("	public function deleteEntry(");
		    s.AppendLine("$" + cols[0] + ")");
		    s.AppendLine("	{");
		    s.AppendLine("		$this->db->where('" + cols[0] + "', $" +  cols[0] + " );");
		    s.AppendLine("		$this->db->delete('" + setting.TableName + "');");
		    s.AppendLine("	}");
		    s.AppendLine("	");
		
		    // Append Update Function
		    s.Append("	public function updateEntry(");
		
		    for(int i = 0; i< cols.Count-1; i++) 
			    s.Append("$" + cols[i] + ", ");
		    s.AppendLine("$" + cols[cols.Count-1] + ")");
		    s.AppendLine("	{");
		    s.AppendLine("		$data = array(");
		
		    for(int i = 1; i< cols.Count-1; i++) 
			    s.AppendLine("			'" + cols[i] + "' => $" + cols[i] + ",");
		    s.AppendLine("			'" + cols[cols.Count-1] + "' => $" + cols[cols.Count-1]);
		
		    s.AppendLine("		);");
			s.AppendLine("		$this->db->where('" + cols[0] + "', $" + cols[0] + ");");
		    s.AppendLine("		$this->db->update('" + setting.TableName + "', $data);");
		    s.AppendLine("		return $this->db->insert_id();");
		    s.AppendLine("	}");
		    s.AppendLine("	");
		
		    //Append Get by ID Function
		    s.Append("	public function getEntryById(");
		    s.AppendLine("$" + cols[0] + ")");
		    s.AppendLine("	{");
		    s.AppendLine("		$conditions = array('" + cols[0] + "' => $" + cols[0] + ");");
			s.AppendLine("		$query = $this->db->get_where('" + setting.TableName + "', $conditions);");
		    s.AppendLine("		return $query->row_array();");
		    s.AppendLine("	}");
		    s.AppendLine("	");
		    
            s.AppendLine("	public function getAllEntries()");
		    s.AppendLine("	{");
		    s.AppendLine("		$query = $this->db->get('" + setting.TableName + "');");
		    s.AppendLine("		return $query->result_array();");
		    s.AppendLine("	}");
		    s.AppendLine("	");

            foreach (SpecialFunction func in setting.SpecialFunctions)
                GenerateSpecialFunction(func);
		
		    s.AppendLine("}");
		    s.AppendLine("");
            _genetaredCode = s.ToString();
        }
        private void GenerateSpecialFunction(SpecialFunction func)
        {
		    List<string> funcs = func.Parameters;
            if(func.Type == SpecialFuntionType.Query)
            {
                s.Append("	public function " + func.Name + "(");
		        for(int i = 0; i< funcs.Count-1; i++) 
			        s.Append("$" + funcs[i] + ",");
		        s.AppendLine("$" + funcs[funcs.Count-1] + ");");
		        s.AppendLine("	{");
		        s.AppendLine("		$conditions = array('");;
		
		        for(int i = 0; i< funcs.Count-1; i++) 
			        s.AppendLine("			'" + funcs[i] + "' => $" + funcs[i] + ",");
		        s.AppendLine("			'" + funcs[-1] + "' => $" + funcs[funcs.Count-1]);
		        s.AppendLine("		);");;
		
		        s.AppendLine("		$query = $this->db->get_where('" + setting.TableName + "', $conditions);");
		    
                if(func.LastRow)
			        s.AppendLine("		return $query->row();");
		        else
			        s.AppendLine("		return $query->result_array();");
		        s.AppendLine("	}");
		        s.AppendLine("	");
            }
        }

    }
}
