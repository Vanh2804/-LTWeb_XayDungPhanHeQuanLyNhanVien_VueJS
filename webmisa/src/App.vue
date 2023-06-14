<template>
    <TheHeader></TheHeader>
    <TheMenu></TheMenu>
    <TheMain></TheMain>
    <TheDialogVue></TheDialogVue>
</template>

<script>
// import HelloWorld from './components/HelloWorld.vue'
import TheMain from './layout/TheMain.vue';
import TheHeader from './layout/TheHeader.vue';
import TheMenu from './layout/TheMenu.vue';
import TheDialogVue from './layout/TheDialog.vue';
export default {
  name: 'App',
  components: {
    // HelloWorld
    TheMain, 
    TheHeader,
    TheMenu, 
    TheDialogVue
  }
}
</script>

<style>
@import url(./css/main.css);
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}
</style>
