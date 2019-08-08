import ConfigService, { Config } from './../config';
import AuthService from "../auth";

export default class ApiService {

	private apiBaseUrl?: string;

	async getBaseUrl() {
		if (this.apiBaseUrl === undefined) {
			let c = await ConfigService.getConfig();
			this.apiBaseUrl = (c as Config).apiEndpointUrl;
		}

		return this.apiBaseUrl;
	}

	async getHttp<T>(path: string): Promise<T> {
		let response = await fetch(`${await this.getBaseUrl()}/${path}`, {
			method: 'GET',
			headers: {
				'Authorization': `Bearer ${AuthService.getToken()}`
			}
		});

		if (!response.ok)
			throw "Error while performing API request";

		let json = await response.json();
		return json as T;
	}
}
