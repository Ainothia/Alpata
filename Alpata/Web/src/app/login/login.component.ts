import { Component } from '@angular/core';
import { LoginRequestDto } from 'src/Models/LoginRequestModel';
import { UserService } from 'src/services/user.service';

@Component({
  selector: 'app-login-component',
  templateUrl: './login.component.html',
  styleUrls: ['./login.css']
})
export class LoginComponent {
  email: string;
  password: string;
  loginModel: LoginRequestDto;

  constructor(
    private userService: UserService
  ) {}
  
  login(){
    this.loginModel = {
      email: this.email,
      password: this.password
    }
    
    this.userService.login(this.loginModel).subscribe(
      (response) => { alert(response) },
      (error) => { console.log(error); });
  };
}


