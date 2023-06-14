import { createApp } from 'vue'
import App from './App.vue'
import MInput from './components/MInput.vue'
import MDropdown from '@/components/MDropdown.vue'

// createApp(App).mount('#app')
const app = createApp(App);
app.component("MInput", MInput);
app.component("MDropdown", MDropdown);
app.mount('#app')
