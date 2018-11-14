import { EndpointFactory } from "./endpoint-factory.service";
import { Injectable, Injector } from "@angular/core";
import { HttpClient, HttpParams } from '@angular/common/http';
import { ConfigurationService } from "./configuration.service";
import { Observable, of } from "rxjs";
import { catchError } from "rxjs/operators";
import { InstallmentType } from "../models/enums";

@Injectable()
export class InstallmentEndpoint extends EndpointFactory {
  private readonly _installmentUrl: string = "/api/installment/";

  get artNotesUrl() { return this.configurations.baseUrl + this._installmentUrl; }

  constructor(http: HttpClient, configurations: ConfigurationService, injector: Injector) {
    super(http, configurations, injector);
  }

  getCalculateInstallment<T>(totalValue: number, numberOfYears: number, installmentType: InstallmentType): Observable<T> {
    let endpointUrl = `${this.artNotesUrl}getCalculateInstallment/`;
    let options: any = this.getRequestHeaders();
    let params = new HttpParams().set('totalValue', JSON.stringify(totalValue))
                                 .set('numberOfYears', JSON.stringify(numberOfYears))
                                 .set('installmentType', JSON.stringify(installmentType));
    options.params = params;
    return this.http.get<T>(endpointUrl, options).pipe<T>(
      catchError(error => {
        return this.handleError(error, () => this.getCalculateInstallment<T>(totalValue, numberOfYears, installmentType));
      }));
  }
}
