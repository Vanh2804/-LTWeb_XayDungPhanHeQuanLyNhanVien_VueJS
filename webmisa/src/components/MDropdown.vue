<template>
    <div class="m-dropdown" >
        <span style="color: #3395FF;">Sửa</span>
        <button class="m-btn-fix item-fix" id="btnFix" @click="btnOnClickOptions"></button>
        <div class="m-fix-options active" id="m-fix-options-id" v-if="isShowOptions">
            <div class="fix-option fix-option-nhanban">Nhân bản</div>
            <div class="fix-option fix-option-xoa">Xóa</div>
            <div class="fix-option fix-option-ngungsudung">Ngưng sử dụng</div>
        </div>
    </div>
</template>
<script>
export default {
    name: "MDropdown",
    
    props: {
        
    },

    watch: {
        
    },

    created() {
        
    },

    methods: {
        btnOnClickOptions(){
            this.isShowOptions == true ? this.isShowOptions = false : this.isShowOptions = true;
        }
    },

    data() {
        return {
            isShowOptions: false
        }
    }
}
</script>

<style scoped>

</style>