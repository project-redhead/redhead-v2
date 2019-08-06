export interface Config {
	apiEndpointUrl: string;
}

export class ConfigService {
	async getConfig(): Promise<Config> {
		let response = await fetch('/config', {
			method: 'GET'
		});

		let json = await response.json();
		let config = json as Config;

		alert(config.apiEndpointUrl);
		return config;
	}
}

export default new ConfigService();
