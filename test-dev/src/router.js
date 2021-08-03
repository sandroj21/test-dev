import Vue from 'vue'
import Router from 'vue-router'
import Index from './views/Index.vue'
import Login from './views/Login.vue'
import Saques from './views/Saques.vue'
import Depositos from './views/Depositos.vue'

Vue.use(Router)

export default new Router({
    mode: 'history',
    routes: [
        {
            path: '/',
            name: 'login',
            component: Login
        },
        {
            path: '/index',
            name: 'index',
            component: Index
        },
        {
            path: '/saques',
            name: 'saques',
            component: Saques
        },
        {
            path: '/depositos',
            name: 'depositos',
            component: Depositos
        }
    ]
})