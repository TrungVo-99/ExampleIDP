import { Injectable, Injector } from "@angular/core";
import { Observable } from "rxjs";
import { TransferState, makeStateKey } from '@angular/platform-browser';
import 'rxjs/Rx';
import { map, catchError } from 'rxjs/operators';

import { unescape } from "querystring";
import { Router } from '@angular/router';


import * as _ from 'lodash';
import { HttpClient, HttpHeaders } from "@angular/common/http";

import { environment } from "../../environments/environment";



@Injectable()
export class ApiService {
  private _baseURl = "";


  constructor(private http: HttpClient) {
    //super(http, configurations, injector);
    this._baseURl = environment.baseUrl;

  }
  private handleError(error: Response) {

    return Observable.throw(error);
  }

  loginSSO(){
    window.location.href = `${this._baseURl}SAML/InitiateSingleSignOn`
   /* return this.http.post(this._baseURl + `SAML/InitiateSingleSignOn?returnurl=${this._baseURl}`, {}).pipe(
      map((res: Response) => res),
      catchError(this.handleError)
    )*/
  }


}
