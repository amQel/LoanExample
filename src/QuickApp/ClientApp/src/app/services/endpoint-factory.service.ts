// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

import { Injectable, Injector } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, Subject, throwError } from 'rxjs';

import { AuthService } from './auth.service';
import { ConfigurationService } from './configuration.service';

@Injectable()
export class EndpointFactory {
  static readonly apiVersion: string = "1";

  private _authService: AuthService;

  private get authService() {
    if (!this._authService)
      this._authService = this.injector.get(AuthService);

    return this._authService;
  }
   
  constructor(protected http: HttpClient, protected configurations: ConfigurationService, private injector: Injector) {

  }

  protected getRequestHeaders(): { headers: HttpHeaders | { [header: string]: string | string[]; } } {
    let headers = new HttpHeaders({
      'Authorization': 'Bearer ' + this.authService.accessToken,
      'Content-Type': 'application/json',
      'Accept': `application/vnd.iman.v${EndpointFactory.apiVersion}+json, application/json, text/plain, */*`,
      'App-Version': ConfigurationService.appVersion
    });

    return { headers: headers };
  }

  
  protected handleError(error, continuation: () => Observable<any>) {
     return throwError(error);
  }
  
}
