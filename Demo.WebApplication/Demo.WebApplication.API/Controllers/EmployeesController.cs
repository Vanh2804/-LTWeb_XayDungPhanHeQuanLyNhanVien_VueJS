using Dapper;
using Demo.WebApplication.API.Entities;
using Demo.WebApplication.API.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Data;
using System.Data.SqlClient;

namespace Demo.WebApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet("{employeeId}")]
        public IActionResult GetEmployeeById([FromRoute]Guid employeeId)
        {
            try
            {
                string storedProcedureName = "Proc_Employee_GetById";

                var parameters = new DynamicParameters();
                parameters.Add("v_EmployeeId", employeeId);

                string connectionString = "Server=localhost;Port=3307;Database=misa_hvanh;Uid=root;Pwd=vanh;";
                var mySqlConnection = new MySqlConnection(connectionString);

                var employee = mySqlConnection.QueryFirstOrDefault<Employee>(storedProcedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);

                if (employee != null)
                {
                    return StatusCode(200, employee);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500, new
                {
                    ErrorCode = 1,
                    traceID = HttpContext.TraceIdentifier,
                }) ;
            }
        }


        [HttpGet]
        public IActionResult GetEmployees()
        {
            try
            {
                string storedProcedureName = "Proc_Employee_Get";


                string connectionString = "Server=localhost;Port=3307;Database=misa_hvanh;Uid=root;Pwd=vanh;";
                var mySqlConnection = new MySqlConnection(connectionString);


                var employees = mySqlConnection.Query(storedProcedureName, commandType: System.Data.CommandType.StoredProcedure);

                if (employees != null)
                {
                    return StatusCode(200, employees);
                }
                else
                {
                    return NotFound();
                }

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500, new
                {
                    ErrorCode = 1,
                    traceID = HttpContext.TraceIdentifier,
                });
            }
        }

        [HttpPost]
        public IActionResult InsertEmployee([FromBody] Employee employee)
        {
            try {
                string storedProcedureName = "Proc_Employee_Post";

                var parameters = new DynamicParameters();
                parameters.Add("v_EmployeeId", employee.EmployeeId);
                parameters.Add("v_FullName", employee.FullName);
                parameters.Add("v_EmployeeCode", employee.EmployeeCode);
                parameters.Add("DateOfBirth", employee.DateOfBirth);
                parameters.Add("v_Gender", employee.Gender);
                parameters.Add("v_CreateBy", employee.CreatedBy);
                parameters.Add("v_ModifiedBy", employee.ModifiedBy);


                string connectionString = "Server=localhost;Port=3307;Database=misa_hvanh;Uid=root;Pwd=vanh;";
                var mySqlConnection = new MySqlConnection(connectionString);

                var row = mySqlConnection.Execute(storedProcedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);

                if (row > 0)
                {
                    return StatusCode(200, "Access");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, new
                {
                    ErrorCode = 1,
                    traceID = HttpContext.TraceIdentifier,
                });
            }
        }

        [HttpDelete]
        public IActionResult DeleteEmployee([FromRoute] Guid employeeId)
        {
            try
            {
                string storedProcedureName = "Proc_Employee_Delete";

                var parameters = new DynamicParameters();
                parameters.Add("v_EmployeeId", employeeId);


                string connectionString = "Server=localhost;Port=3307;Database=misa_hvanh;Uid=root;Pwd=vanh;";
                var mySqlConnection = new MySqlConnection(connectionString);

                var row = mySqlConnection.Execute(storedProcedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);

                if (row != null)
                {
                    return StatusCode(200, "Access");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, new
                {
                    ErrorCode = 1,
                    traceID = HttpContext.TraceIdentifier,
                });
            }
        }

        [HttpPut]
        public IActionResult PutEmployee([FromBody] Employee employee)
        {
            try
            {
                string storedProcedureName = "Proc_Employee_Put";

                var parameters = new DynamicParameters();
                parameters.Add("v_EmployeeId", employee.EmployeeId);
                parameters.Add("v_FullName", employee.FullName);
                parameters.Add("v_EmployeeCode", employee.EmployeeCode);
                parameters.Add("DateOfBirth", employee.DateOfBirth);
                parameters.Add("v_Gender", employee.Gender);
                parameters.Add("v_ModifiedBy", employee.ModifiedBy);


                string connectionString = "Server=localhost;Port=3307;Database=misa_hvanh;Uid=root;Pwd=vanh;";
                var mySqlConnection = new MySqlConnection(connectionString);

                var row = mySqlConnection.Execute(storedProcedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);

                if (row != null)
                {
                    return StatusCode(200, "Access");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, new
                {
                    ErrorCode = 1,
                    traceID = HttpContext.TraceIdentifier,
                });
            }
        }

    }
}
