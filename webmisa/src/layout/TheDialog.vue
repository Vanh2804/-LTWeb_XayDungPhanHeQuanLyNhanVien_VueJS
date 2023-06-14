<template>
    <div class="dialog" style="display: none;">
        <div class="dialog-form dialog-erorr" style="display: none;">
            <div class="dialog-content">
                <div class="dialog-icon item-error"></div>
                <div class="dialogdescribe" style="width: 300px;"></div>
            </div>
            <button class="btn btn-default btnAccess">Đồng ý</button>
        </div>
        <div class="dialog-form dialog-warring-delete" style="display: none;">
            <div class="dialog-content">
                <div class="dialog-icon item-warring"></div>
                <div class="dialogdescribe" style="width: 300px;"></div>
            </div>
            <div style="display: flex; justify-content: space-between; margin: 0 24px;">
                <button class="btn btnClost" st>Không</button>
                <button class="btn btn-default btnAccess">Đồng ý</button>
            </div>
        </div>
        <div class="dialog-form dialog-warring-fix" style="display: none;">
            <div class="dialog-content">
                <div class="dialog-icon item-warring"></div>
                <div class="dialogdescribe" style="width: 300px;"></div>
            </div>
            <button class="btn btn-default btnClose" style="margin-left: 160px;">Đồng ý</button>
        </div>
    </div>
</template>

<script>
export default{
    name: "TheDialog"
}
</script>

<style scoped>

</style>