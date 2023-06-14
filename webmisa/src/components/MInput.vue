<template>
    <div class="input-wrapper">
    <label v-if="label" for=""
      >{{ label }} <span v-if="required" class="required">*</span></label
    >
    <input
      :placeholder="placeholder"
      :class="{ 'invalid': invalid }"
      type="text"
      class="txtEmployeeCode"
      id="input_chucdanh"
      v-model="value"
      @blur="onvalidateBlur"
    />
  </div>
</template>
<script>
export default {
    name: "MInput",
    

    props: {
        modelValue: [String, Number, Boolean],
        label: {
            type: String,
            required: false,
            default: null
        },
        required: {
            type: Boolean,
            required: false,
            default: false
        },
        placeholder: {
            type: String,
            required: false,
            default: null
        },
        
    },

    watch: {
        value: function(newValue) {
            console.log(newValue);
            this.$emit("update:modelValue", newValue);
        }
    },

    created() {
        // this.value = this.modelValue;
    },

    methods: {
        onvalidateBlur() {
            if (this.required && !this.value) {
                this.invalid = true;
            } else {
                this.invalid = false;
            }
        }
    },

    data() {
        return {
            value: null,
            invalid: false
        }
    }
}
</script>

<style scoped>
@import url(../css/components/input.css);
</style>