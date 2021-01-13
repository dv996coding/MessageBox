import Vue from 'vue'
import App from './App.vue'
//import VCharts from 'v-charts'

Vue.config.productionTip = false

//Vue.use(VCharts)

new Vue({
  render: h => h(App),
}).$mount('#app')
