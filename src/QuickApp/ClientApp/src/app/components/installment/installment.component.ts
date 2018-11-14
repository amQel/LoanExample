import { Component } from '@angular/core';
import { fadeInOut } from '../../services/animations';
import { InstallmentService } from '../../services/installment.service';
import { InstallmentType } from '../../models/enums';
import { BehaviorSubject } from 'rxjs';
import { Installment } from '../../models/installment.model';

@Component({
  selector: 'installment',
  templateUrl: './installment.component.html',
  styleUrls: ['./installment.component.css'],
  animations: [fadeInOut]
})
export class InstallmentComponent {
  InstallmentType = InstallmentType;
  installments = new BehaviorSubject<Installment[]>([]);
  loanValue: number = 100000;
  loanLength: number = 3;
  installmentType = InstallmentType.Decreasing;

  constructor(private installmentService: InstallmentService) {

  }
  calculateInstallment() {
    this.installmentService.getCalculateInstallments(this.loanValue, this.loanLength, this.installmentType).subscribe((instalmentsResult: Installment[]) => {
      this.installments.next(instalmentsResult);
    }, error => {
      console.log(error);
      this.installments.next([]);
    });
  }

  setMinLoanValue() {
    if (this.loanValue < 1) {
      this.loanValue = 1;
    }
  }

  setMinLoanLength() {
    if (this.loanLength < 1) {
      this.loanLength = 1;
    }
  }
}
