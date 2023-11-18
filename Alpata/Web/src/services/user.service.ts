import { HttpClient } from  '@angular/common/http';
import { Injectable } from  '@angular/core';
import { LoginRequestDto } from 'src/Models/LoginRequestModel';
import { SaveUserRequestDto } from 'src/Models/RegisterRequestDto';

@Injectable({
providedIn:  'root'
})

export class UserService {

    private baseUrl = 'https://localhost:7143/user/';

    constructor(private http: HttpClient) { }

    login(model : LoginRequestDto) {
        return this.http.post(this.baseUrl + "login",model);
    }

    register(model: FormData){
        return this.http.post(this.baseUrl + "save",model);
    }

}