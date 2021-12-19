import HttpUtil from "../http/HttpUtil.js";

export default class IrpfDriver {
    constructor() {
        this.xhr = new HttpUtil();
    }

    async calculate(person) {
        const response = await this.xhr.post("http://localhost:5000", "/api/irpf/calculate", person.toObj());
        return await response.json();
    }
}