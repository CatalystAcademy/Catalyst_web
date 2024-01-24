<!-- components/LanguageSwitcher.vue -->
<template>
  <div>
    <button @click="switchLanguage('en-US')">English</button>
    <button @click="switchLanguage('hy-AM')">Armenian</button>
    <!-- Add more language buttons as needed -->
  </div>
</template>

<script>
export default {
  methods: {
    switchLanguage(language) {
      console.log('Switching language to', language);
      this.$store.commit('setLanguage', language);
      //this.$store.dispatch('fetchTranslations');
      this.$i18n.setLocale(language);
    },
  },
};
</script>
