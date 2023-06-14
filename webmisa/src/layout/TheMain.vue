<template>
    <div class="content">
        <div class="page_header">
            <div class="page-header_left">Nhân viên</div>
            <div class="page-header_right">
                <button class="btn btn-default" @click="btnAddOnClickPopup" fdprocessedid="nicul">Thêm mới nhân viên</button>
            </div>
        </div>
        <div class="page_content">
            <div class="table-wrapper">
                <div class="table_toolbar">
                    <div class="box_search">
                        <button class="btnsearch" fdprocessedid="6ipw39"></button>
                        <input type="search" class="input_search" placeholder="Tìm theo mã, tên nhân viên">   
                    </div>
                    <button class="btnrefresh" fdprocessedid="v8566"></button>
                </div>
                <div class="table">
                    <table class="m-table" id="table-list">
                        <thead>
                            <tr class="importain-active">
                                <th class="text-align-center checkbox-sticky" type="checkbox">
                                    <input type="checkbox" class="input-checkbox">
                                </th>
                                <th class="text-align-left" model-name="EmployeeCode">MÃ NHÂN VIÊN</th>
                                <th class="text-align-left" model-name="FullName">TÊN NHÂN VIÊN</th>
                                <th class="text-align-left" model-name="GenderName">GIỚI TÍNH</th>
                                <th class="text-align-center" model-name="DateOfBirth">NGÀY SINH</th>
                                <th class="text-align-left" model-name="IdentityNumber">SỐ CCCD</th>
                                <th class="text-align-left" model-name="PositionName">CHỨC DANH</th>
                                <th class="text-align-left" model-name="DepartmentName">TÊN ĐƠN VỊ</th>
                                <th class="text-align-left" model-name="PersonalTaxCode">SỐ TÀI KHOẢN</th>
                                <th class="text-align-left" model-name="PhoneNumber">TÊN TÀI KHOẢN</th>
                                <th class="text-align-left" model-name="IdentityPlace">CHI NHÁNH TK NGÂN HÀNG</th>
                                <th class="text-align-left" type="options">CHỨC NĂNG</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr @dblclick="$event => rowOnDbClick(item)" v-for="(item, index) in employees" :key="index">
                                <td class="text-align-center checkbox-sticky">
                                    <input type="checkbox" class="input-checkbox">
                                </td>
                                <td class="text-align-left">{{item.EmployeeCode}}</td>
                                <td class="text-align-left">{{item.FullName}}</td>
                                <td class="text-align-left">{{item.GenderName}}</td>
                                <td class="text-align-center">{{formatDate(item.DateOfBirth)}}</td>
                                <td class="text-align-left">{{item.IdentityNumber}}</td>
                                <td class="text-align-left">{{item.PositionName}}</td>
                                <td class="text-align-left">{{item.DepartmentName}}</td>
                                <td class="text-align-left">{{item.PersonalTaxCode}}</td>
                                <td class="text-align-left">{{item.PhoneNumber}}</td>
                                <td class="text-align-left">{{item.IdentityPlace}}</td>
                                <td >
                                    <!-- <div class="m-dropdown" >
                                        <span style="color: #3395FF;">Sửa</span>
                                        <button class="m-btn-fix item-fix" id="btnFix" @click="btnOnClickOptions"></button>
                                        <div class="m-fix-options active" id="m-fix-options-id" v-show="isShowOptions">
                                            <div class="fix-option fix-option-nhanban">Nhân bản</div>
                                            <div class="fix-option fix-option-xoa">Xóa</div>
                                            <div class="fix-option fix-option-ngungsudung">Ngưng sử dụng</div>
                                        </div>
                                    </div> -->
                                    <MDropdown @click="btnOnClickOptions"></MDropdown>
                                </td>
                            </tr>  
                        </tbody>
                    </table>
                </div>
                <div class="table_padding">
                    <div class="table-padding_left">Tổng số: bản ghi</div>
                    <div class="table-padding_right">
                        <select name="" id="" fdprocessedid="8z04ee">
                            <option value="">20 bản ghi trên 1 trang</option>
                            <option value="">30 bản ghi trên 1 trang</option>
                            <option value="">50 bản ghi trên 1 trang</option>
                        </select>`
                        <button class="m-btn-first" fdprocessedid="fx4pgl"></button>
                        <div class="m-page-number-group">
                            <button class="m-page-number m-page-selected" fdprocessedid="t101c">1</button>
                            <button class="m-page-number" fdprocessedid="8ouwi">2</button>
                            <button class="m-page-number" fdprocessedid="i0uo8i">3</button>
                            <button class="m-page-number" fdprocessedid="0bcrur">•••</button>
                            <button class="m-page-number" fdprocessedid="glvjtg">1</button>
                        </div>
                        <button class="m-btn-next" fdprocessedid="0kq9l"></button>
                    </div>
                </div>
            </div>
        </div>
    </div>   

    <EmployeeDetail v-show ="isShowPopup"   @hidePopup = "hidePopup"></EmployeeDetail>
    
</template>

<script>
// import MISAResource from '../js/resource';
import EmployeeDetail from '../views/EmployeeDetail';
// import MDropdown from '@/components/MDropdown.vue';
export default{
    name: "TheMain",
    components: {EmployeeDetail},
    created(){
        fetch(`"https://apidemo.laptrinhweb.edu.vn/api/v1/Employees"`)
            .then(res => res.json())
            .then(data =>{
                console.log(data);
                this.employees = data;
            })
    },
    
    methods: {
        rowOnDbClick (employee) {
            this.isShowPopup = true;
            this.employeeIdSelected = employee.EmployeeId;
            this.empSelected = employee;
            console.log(this.employeeIdSelected);
            console.log(employee);
        },
        btnAddOnClickPopup(){
            this.isShowPopup = true;
        },
        btnOnClickOptions(){
            this.isShowOptions == true ? this.isShowOptions = false : this.isShowOptions = true;
        },
        /**
         * hàm định dạng ngày tháng
         * @param {date} date ngay thang
         * Author: Vanh (01/03/2022)
         */
        formatDate(date){
            try {
                date = new Date(date);
                let dateVaule = date.getDate();
                let month = date.getMonth() + 1;
                let year = date.getFullYear();
                return `${dateVaule}/${month}/${year}`;
            } catch (error) {
                return error;
            }
        },
        /**
         * ẩn popup
         * author: vanh (03/03/2023)
         */
        hidePopup(){
            this.isShowPopup = false;
        },
    },
    data() {
        return {
            employees: [],
            isShowPopup: false,
            employeeIdSelected: null,
            empSelected: {},
        }
    },
}
</script>

<style scoped>

</style>