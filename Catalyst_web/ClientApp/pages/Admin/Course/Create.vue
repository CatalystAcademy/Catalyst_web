<template>
  <div>
    <form @submit.prevent="create" action="/assets/inc/sendemail.php">
      <input v-model="createData.titleArm" type="text" placeholder="Title in Armenian" name="titleArm">
      <input v-model="createData.titleEng" type="text" placeholder="Title in English" name="titleEng">
      <input v-model="createData.descriptionArm" type="text" placeholder="Description in Armenian" name="descriptionArm">
      <input v-model="createData.descriptionEng" type="text" placeholder="Description in English" name="descriptionEng">
      <client-only>
        <b-form-datepicker id="datepicker-full-width"
                           v-model="createData.startDate"
                           :show-decade-nav="showDecadeNav"
                           :hide-header="hideHeader"
                           class="mb-2"
                           placeholder="Choose a date"
                           menu-class="w-80"
                           calendar-width="100%">
        </b-form-datepicker>
        <b-form-datepicker id="example-i18n-picker2"
                           v-model="createData.endDate"
                           :show-decade-nav="showDecadeNav"
                           :hide-header="hideHeader"
                           class="mb-2"
                           placeholder="Choose a date"
                            menu-class="w-80"
                            calendar-width="100%">
        </b-form-datepicker>
        </client-only>
        <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
</form><!-- /.become-teacher__form-content -->
  </div>

</template>

<script>
  import https from 'https';
  export default {
    name: 'CreateCourse',
    data() {
      return {
        value: '',
        showDecadeNav: true,
        hideHeader: true
      }
    },
    setup() {
      return {
        createData: { titleArm: '', titleEng: '', descriptionArm: '', descriptionEng: '', startDate: '', endDate: '' },
      };
    },
    methods: {
      async create() {
        try {
          await this.$axios.post('/api/Courses/Create', this.createData)
          // Show success message
            .then(function (response) {
              if (response) {
                window.location = "/admin/Course/List"
              }
            })
            .catch(function (error) {
              
            })
        } catch (error) {
          // Handle error and display message
        }
      },
    },
    created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  }
</script>

<style scoped>
  .form-control {
    height: auto !important;
  }
</style>
