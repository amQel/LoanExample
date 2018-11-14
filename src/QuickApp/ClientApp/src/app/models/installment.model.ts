export class Installment {

  constructor(value?: number, installmentNumber?: number) {
    this.value = value;
    this.installmentNumber = installmentNumber;
  }
  public value: number;
  public installmentNumber: number;
}
