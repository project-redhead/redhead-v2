export interface Config {
	apiEndpointUrl: string;
}

export class ConfigService {
	async getConfig(): Promise<Config | undefined> {
		let response = await fetch('/config', {
			method: 'GET'
		});

		let json = await response.json();
		let config = json as Config;

		return config;
	}
}

export default new ConfigService();
