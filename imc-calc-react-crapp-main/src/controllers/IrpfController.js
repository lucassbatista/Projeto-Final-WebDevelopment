export default class IrpfController {
  constructor() {
      this.imcDriver = null;
  }

  async calculate(person) {
      if (!this.imcDriver) {
          const { default: ImcDriver } = await import("../drivers/IrpfDriver.js")
          this.imcDriver = new ImcDriver();
      }

      return await this.imcDriver.calculate(person);
  }
}