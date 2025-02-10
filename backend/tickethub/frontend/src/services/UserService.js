import axios from "axios";
import { USER_BASE_URL } from "../constants/ApiConstants";

export function signInUser(user) {
    return axios.post(`${USER_BASE_URL}authenticate`, user);
}

export function signUpUser(user) {
    return axios.post(`${USER_BASE_URL}`, user);
}

export function updateUser(id, user) {
    let data=JSON.parse(sessionStorage.getItem('user_details'));
    return axios.put(`${USER_BASE_URL}${id}`, user,
        {
            headers: {
                Authorization: `Bearer ${data.token}`
            }  
        }
    );
}

export function validateEmail(email) {
    return axios.get(`${USER_BASE_URL}validateEmail`, {
        params: { email },
    });
}

export function validatePhoneNo(phone) {    
    return axios.get(`${USER_BASE_URL}validatePhone`, {
        params: { phone },
    });    
}