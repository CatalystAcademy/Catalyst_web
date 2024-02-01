// store/index.js
import https from 'https';

export const state = () => ({
  language: 'en-US',
  translations: {},
  isRequestInfoModalOpen: false,
});

export const mutations = {
  setLanguage(state, language) {
    state.language = language;
  },
  setTranslations(state, translations) {
    state.translations = translations;
  },
  setRequestInfoModalState(state, isOpen) {
    state.isRequestInfoModalOpen = isOpen;
  },
};

export const actions = {
  async fetchTranslations({ commit, state }) {
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    try {
      const response = await this.$axios.get(`/api/Translations?languageCode=${state.language}`);
      commit('setTranslations', response.data);
    } catch (error) {
      console.error('Error fetching translations:', error);
    }
  },
  openRequestInfoModal({ commit }) {
    commit('openRequestInfoModal');
  },

  closeRequestInfoModal({ commit }) {
    commit('closeRequestInfoModal');
  },
};


