import axios from 'axios'

const api = axios.create({
    baseURL: 'https://localhost:44371/api'
})

export default api;