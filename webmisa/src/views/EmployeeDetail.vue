<template>
    <div class="popup importain-active" id="frmDetail">
        <div submit.prevent="addEmployee" class="popup-form" id="frm-popup">
            <button class="popup_button" id="btnClose" @click="btnClosePopup"></button>
            <div class="popup_header">
                <h1>Thông tin nhân viên</h1>
                <div class="popup_header-detail">
                    <input type="radio" id="txtEmployeeCode" name="pr-detail">
                    <label for="txtEmployeeCode" class="male">Là khách hàng</label>
                    <input type="radio" id="txtEmployeeCode" name="pr-detail">
                    <label for="txtEmployeeCode">Là nhà cung cấp</label>
                </div>
            </div>
            <div class="popup_body">
                <div class="employee-info">
                    <div class="form-group general-info-left">
                        <div class="m-row m-flex m-col-gap-8">
                            <!-- <div class="input-wrapper" >
                                <label for="input_ma">Mã <span class="required">*</span></label>
                                <input :class="{'invalid':invalid}" type="text" class="txtEmployeeCode" id="input_ma" v-model="value" @blur="onValidateBlur">
                                <span class="form-message">{{ value }}</span>      
                            </div> -->
                            <MInput label="Ma" required="true"  placeholder="Mã" style="width: 100px;"></MInput>
                            <!-- <div class="input-wrapper">
                                <label for="input_name">Tên <span class="required">*</span> </label>
                                <input :class="{'invalid':invalid}" type="text" class="txtEmployeeCode" id="input_name">
                                <span class="form-message"></span>
                            </div> -->
                            <MInput label="Ten" required="true"></MInput>
                        </div>
                        <div class="m-row m-flex m-col-gap-8">
                            <div class="input-wrapper">
                                <label for="input_donvi">Dơn vị <span class="required">*</span> </label>
                                <select id="input_donvi">
                                    <!-- <option selected></option> -->
                                    <option>Ban giám đốc</option>
                                    <option>Ban giám đốc</option>
                                </select>
                                <span class="form-message"></span>
                            </div>
                        </div>
                        <div class="m-row m-flex m-col-gap-8">
                            <div class="input-wrapper">
                                <label for="input_chucdanh">Chức danh</label>
                                <input type="text" class="txtEmployeeCode" id="input_chucdanh">
                            </div>
                        </div>
                    </div>
                    <div class="form-group general-info-right">
                        <div class="m-row m-flex m-col-gap-8">
                            <div class="input-wrapper" style="width: 160px;">
                                <label for="input_ngaysinh">Ngày sinh</label>
                                <input type="date" class="txtEmployeeCode" id="input_ngaysinh">
                                <span class="form-message"></span>
                            </div>
                            <div class="input-wrapper">
                                <label for="input-gender">Giới tính</label>
                                <div class="input-gender m-col-gap-8">
                                    <input type="radio" id="txtEmployeeCode" name="gender">
                                    <label for="txtEmployeeCode" class="male">Nam</label>
                                    <input type="radio" id="txtEmployeeCode" name="gender">
                                    <label for="txtEmployeeCode">Nữ</label>
                                    <input type="radio" id="txtEmployeeCode" name="gender">
                                    <label for="txtEmployeeCode">Khác</label>
                                </div>
                            </div>
                        </div>

                        <div class="m-row m-flex m-col-gap-8">
                            <div class="input-wrapper">
                                <label for="input_cccd" title="So can cuoc cong dan">Số CCCD</label>
                                <input type="text" id="input_cccd">
                            </div>
                            <div class="input-wrapper">
                                <label for="input_ngaycapcccd">Ngày cấp</label>
                                <input type="date" class="txtEmployeeCode" id="input_ngaycapcccd"
                                    style="width: calc(100% - 24px);">
                                <span class="form-message"></span>
                            </div>
                        </div>
                        <div class="m-row">
                            <div class="input-wrapper">
                                <label for="input_noicap">Nơi cấp</label>
                                <input type="text" class="txtEmployeeCode" id="input_noicap">
                            </div>
                        </div>
                    </div>
                    <div class="form-group contact-info">
                        <div class="m-row m-flex m-col-gap-8">
                            <div class="input-wrapper">
                                <label for="input_diachi">Địa chỉ</label>
                                <input type="text" class="txtEmployeeCode" id="input_diachi">
                            </div>
                        </div>
                        <div class="m-row m-flex m-col-gap-8">
                            <div class="input-wrapper">
                                <label for="input_dtdd" title="So can cuoc cong dan">ĐT di động</label>
                                <input type="text" class="txtEmployeeCode" id="input_dtdd">
                            </div>
                            <div class="input-wrapper">
                                <label for="input_dtcodinh" title="So can cuoc cong dan">ĐT cố định</label>
                                <input type="text" class="txtEmployeeCode" id="input_dtcodinh">
                            </div>
                            <div class="input-wrapper">
                                <label for="input_email" title="So can cuoc cong dan">Email</label>
                                <input type="text" class="txtEmployeeCode" id="input_email">
                                <span class="form-message"></span>
                            </div>
                        </div>
                        <div class="m-row m-flex m-col-gap-8">
                            <div class="input-wrapper">
                                <label for="input_tknh">Tài khoản ngân hàng</label>
                                <input type="text" class="txtEmployeeCode" id="input_tknh">
                            </div>
                            <div class="input-wrapper">
                                <label for="input_tennh">Tên ngân hàng</label>
                                <input type="text" class="txtEmployeeCode" id="input_tennh">
                            </div>
                            <div class="input-wrapper">
                                <label for="input_chinhanh">Chi nhánh</label>
                                <input type="text" class="txtEmployeeCode" id="input_chinhanh">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="popup_footer">
                <div class="footer_left">
                    <button class="btn" id="btnCancel" @click="btnClosePopup">Hủy</button>
                </div>
                <div class="footer_right">
                    <button class="btn" style="margin-right: 8px;">Cất</button>
                    <button class="btn btn-default">Cất và thêm</button>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
// import MInput from '../components/MInput.vue';  
export default {
    name: "EmployeeDetail",
    // components: {MInput},
    props: {

    },
    created() {
        // Lưu trữ dữ liệu ban đầu (trước khi bị chỉnh sửa)
        this.dataOld = JSON.stringify(this.employeeInput);

        // Chuyển dữ liệu từ props sang data:
        this.employee = this.employeeInput;

        // Lấy data về:
        if (this.employeeId) {
            fetch(`https://apidemo.laptrinhweb.edu.vn/api/v1/Employees/${this.employeeId}`)
                .then(res => res.json())
                .then(data => {
                    console.log(data);
                    this.employee = data;
                })
        }
    },
    methods: {
        /**
         * Ẩn form
         * author: Vanh (03/03/2023)
         */
        btnClosePopup() {
            this.$emit("hidePopup");
        },
        btnCloseOnClick() {
            // Kiểm tra dữ liệu đã thay đổi hay chưa
            const dataNew = JSON.stringify(this.employee);
            console.log(dataNew);
            console.log(this.dataOld);

            if (dataNew != this.dataOld) {
                alert("Bạn đã thay đổi dữ liệu, có muốn xóa không?");
            }
            this.hideFunction();
        },
        // addEmployee() {
        //     fetch("https://localhost:7082/api/Employees/", {
        //         headers: {
        //             "Content-Type": "application/json",
        //         },
        //         body: JSON.stringify({
        //         }),
        //     })
        //         .then((response) => response.json())
        //         .then((data) => {
        //             console.log(this.employee);
        //             console.log(data);
        //             this.$emit("hideMe");
        //         })
        //         .catch((error) => {
        //             console.log(error);
        //         });
        // },
    },
    data() {
        return {
            fullname: "vanh Hoang",
            employee: {},
            dataOld: null
            
        }
    },
}
</script>

<style scoped></style>