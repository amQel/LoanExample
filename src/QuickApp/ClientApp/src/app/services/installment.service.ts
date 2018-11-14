import { Injectable } from '@angular/core';
import { InstallmentEndpoint } from './installment-endpoint.service';
import { InstallmentType } from '../models/enums';

@Injectable()
export class InstallmentService {

  constructor(private installmentEndpoint: InstallmentEndpoint) {
  }

  getCalculateInstallments(totalValue: number, numberOfYears: number, installmentType: InstallmentType) {
    return this.installmentEndpoint.getCalculateInstallment(totalValue, numberOfYears, installmentType);
  }

}
